using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : IMenuItemExecution
    {
        private string r_TitleOfMenu;
        private List<MenuItem> m_SubMenuItems = new List<MenuItem>();
        public IMenuItemExecution m_ActionToPerform;

        public MenuItem(string i_TitleOfMenu, IMenuItemExecution i_ActionToPerform = null)
        {
            r_TitleOfMenu = i_TitleOfMenu;
            m_ActionToPerform = i_ActionToPerform;
        }

        public string TitleOfMenu
        {
            get
            {
                return r_TitleOfMenu;
            }
        }

        public List<MenuItem> GetSubItems()
        {
            return m_SubMenuItems;
        }

        public IMenuItemExecution ActionToPerform
        {
            get
            {
                return m_ActionToPerform;
            }
        }

        public void AddSubItem(MenuItem i_SubItemToAdd)
        {
            m_SubMenuItems.Add(i_SubItemToAdd);
        }

        public void Execute()
        {
            if (m_ActionToPerform != null)
            {
                m_ActionToPerform.Execute();
            }
        }
    }
}
