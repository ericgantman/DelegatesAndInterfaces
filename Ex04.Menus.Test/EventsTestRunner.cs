using Ex04.Menus.Events;
using System;

namespace Ex04.Menus.Test
{
    public class EventsTestRunner
    {
        public static void CreateEventsMenu()
        {
            MainMenu mainMenuDelegates = new MainMenu("Delegates Main Menu");
            MenuItem versionAndCapitalsMenu = new MenuItem("Version and Capitals");
            MenuItem showDateTimeMenu = new MenuItem("Show Date/Time");
            MenuItem showTimeMenuItem = new MenuItem("Show Time");
            MenuItem showDateMenuItem = new MenuItem("Show Date");
            MenuItem showVersionMenuItem = new MenuItem("Show Version");
            MenuItem countCapitalsMenuItem = new MenuItem("Count Capitals");

            showTimeMenuItem.ActionToPerform += new Action<MenuItem>(showTimeEventHandler);
            showDateMenuItem.ActionToPerform += new Action<MenuItem>(showDateEventHandler);
            showVersionMenuItem.ActionToPerform += new Action<MenuItem>(showVersionEventHandler);
            countCapitalsMenuItem.ActionToPerform += new Action<MenuItem>(countCapitalsEventHandler);
            versionAndCapitalsMenu.AddSubItem(showVersionMenuItem);
            versionAndCapitalsMenu.AddSubItem(countCapitalsMenuItem);
            mainMenuDelegates.RootMenu.AddSubItem(versionAndCapitalsMenu);
            showDateTimeMenu.AddSubItem(showTimeMenuItem);
            showDateTimeMenu.AddSubItem(showDateMenuItem);
            mainMenuDelegates.RootMenu.AddSubItem(showDateTimeMenu);
            mainMenuDelegates.Show();
        }

        private static void showTimeEventHandler(MenuItem i_MenuItemSent)
        {
            new ShowTime().Execute();
        }

        private static void showDateEventHandler(MenuItem i_MenuItemSent)
        {
            new ShowDate().Execute();
        }

        private static void showVersionEventHandler(MenuItem i_MenuItemSent)
        {
            new ShowVersion().Execute();
        }

        private static void countCapitalsEventHandler(MenuItem i_MenuItemSent)
        {
            new CountCapitals().Execute();
        }
    }
}