using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly MenuItem r_RootMenu;
        private Stack<MenuItem> m_MenuStacHierarchy;

        public MainMenu(string i_RootTitleMenu)
        {
            r_RootMenu = new MenuItem(i_RootTitleMenu);
            m_MenuStacHierarchy = new Stack<MenuItem>();
            m_MenuStacHierarchy.Push(r_RootMenu);
        }

        public Stack<MenuItem> MenuStackHierarchy
        {
            get
            {
                return m_MenuStacHierarchy;
            }
        }

        public MenuItem RootMenu
        {
            get
            {
                return r_RootMenu;
            }
        }

        public void Show()
        {
            int userValidChoice;
            string quitMenuOption;
            MenuItem currentMenu;

            while (m_MenuStacHierarchy.Any())
            {
                currentMenu = m_MenuStacHierarchy.Peek();
                quitMenuOption = m_MenuStacHierarchy.Count > 1 ? "Back" : "Exit";
                displayMenu(currentMenu, quitMenuOption);
                userValidChoice = getUserChoice(currentMenu.GetSubItems().Count, quitMenuOption);
                handleUserChoice(userValidChoice, currentMenu);
            }
        }

        private void displayMenu(MenuItem i_CurrentMenu, string i_QuitMenuOption)
        {
            StringBuilder menuDisplay = new StringBuilder();
            List<MenuItem> subItemsInMenu;

            Console.Clear();
            menuDisplay.AppendLine($"**{i_CurrentMenu.TitleOfMenu}**");
            menuDisplay.AppendLine("------------------------");
            subItemsInMenu = i_CurrentMenu.GetSubItems();
            for (int i = 0; i < subItemsInMenu.Count; i++)
            {
                menuDisplay.AppendLine($"{i + 1} -> {subItemsInMenu[i].TitleOfMenu}");
            }

            menuDisplay.AppendLine($"0 -> {i_QuitMenuOption}");
            Console.WriteLine(menuDisplay.ToString());
        }

        private void handleUserChoice(int i_UserValidChoice, MenuItem i_CurrentMenu)
        {
            MenuItem selectedMenuItem;

            if (i_UserValidChoice == 0)
            {
                if (m_MenuStacHierarchy.Count > 1)
                {
                    m_MenuStacHierarchy.Pop();
                }
                else
                {
                    m_MenuStacHierarchy.Clear();
                }
            }
            else
            {
                selectedMenuItem = i_CurrentMenu.GetSubItems()[i_UserValidChoice - 1];
                if (selectedMenuItem.GetSubItems().Any())
                {
                    m_MenuStacHierarchy.Push(selectedMenuItem);
                }
                else
                {
                    selectedMenuItem.m_ActionToPerform?.Execute();
                    Thread.Sleep(3500);
                }
            }
        }

        private int getUserChoice(int i_MaxOption, string i_QuitMenuOption)
        {
            int o_UserValidChoice;

            do
            {
                Console.WriteLine(string.Format("Enter your request: (1 to {0} or '0' to {1})", i_MaxOption, i_QuitMenuOption));
            } while (!int.TryParse(Console.ReadLine(), out o_UserValidChoice) || o_UserValidChoice < 0 || o_UserValidChoice > i_MaxOption);

            return o_UserValidChoice;
        }
    }
}