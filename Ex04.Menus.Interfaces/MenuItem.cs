using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem 
    {
        private string m_ItemName;
        private List<MenuItem> m_MenuItems = new List<MenuItem>();
        private List<IShowMenu> m_ShowMenus = new List<IShowMenu>();

        public MenuItem(string i_ItemName)
        {
            m_ItemName = i_ItemName;
        }

        public string ItemName
        {
            get 
            {
                return m_ItemName;
            }
            set 
            {
                m_ItemName = value; 
            }
        }

        public void AddItemsToListMenuItems(MenuItem i_MenuItem)
        {
            m_MenuItems.Add(i_MenuItem);
        }

        public void RemoveItemsToListMenuItems(MenuItem i_MenuItem)
        {
            m_MenuItems.Remove(i_MenuItem);
        }
        // print second menu

        public void PrintItemMenu()
        {
            Console.WriteLine(m_ItemName);
            Console.WriteLine("----------------------");
            for (int i = 0; i < m_MenuItems.Count; i++)
            {
                Console.WriteLine("{0} -> {1}", i + 1, m_MenuItems[i].ItemName);
            }
            Console.WriteLine("0 - > Back");
            Console.WriteLine("----------------------");
        }
    }
}
