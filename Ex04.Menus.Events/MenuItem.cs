using System;
using System.Collections.Generic;

namespace Ex04.Menus.Events
{
    public class MenuItem
    {
        private string r_TitleOfMenu;
        private List<MenuItem> m_SubMenuItems = new List<MenuItem>();

        public event Action<MenuItem> ActionToPerform;

        public MenuItem(string i_TitleOfMenu, Action<MenuItem> i_ActionToPerform = null)
        {
            r_TitleOfMenu = i_TitleOfMenu;
            ActionToPerform += i_ActionToPerform;
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

        public void AddSubItem(MenuItem i_SubItemToAdd)
        {
            m_SubMenuItems.Add(i_SubItemToAdd);
        }

        protected virtual void OnUserRequest()
        {
            if (ActionToPerform != null)
            {
                ActionToPerform.Invoke(this);
            }
        }

        public void InvokeAction()
        {
            OnUserRequest();
        }
    }
}