using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : IShow
    {
        private string m_ItemName;
        private List<MenuItem> m_MenuItems;
        //private List<IShowMenu> m_ShowMenus;// = new List<IShowMenu>();
        private IShow m_ShowOperation;


        public MenuItem(string i_ItemName)
        {
            m_ItemName = i_ItemName;
            m_MenuItems = new List<MenuItem>();
            m_ShowOperation = null;
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

        public IShow ShowOperation
        {
            get { return m_ShowOperation; }
            set { m_ShowOperation = value; } 
        }

      

        public void AddItemsToListMenuItems(MenuItem i_MenuItem)
        {
            m_MenuItems.Add(i_MenuItem);
        }

        public void RemoveItemsFromListMenuItems(MenuItem i_MenuItem)
        {
            m_MenuItems.Remove(i_MenuItem);
        }
        // print second menu

        public void PrintItemMenu()
        {
            Console.WriteLine("**{0}**",m_ItemName);
            Console.WriteLine("----------------------");
            for (int i = 0; i < m_MenuItems.Count; i++)
            {
                Console.WriteLine("{0} -> {1}", i + 1, m_MenuItems[i].ItemName);
            }
            Console.WriteLine("0 - > Back");
            Console.WriteLine("----------------------");
        }

        public void PrintUserChoice()
        {
            if(m_MenuItems.Count > 0)
            {
                Show();
            }
            else
            {
                m_ShowOperation.Show();
            }
        }

        public void Show()
        {
            bool userChooseBack = false;
            do
            {
                PrintItemMenu();
                try
                {
                    Console.WriteLine("Enter your request: ");
                    int userChoice = int.Parse(Console.ReadLine());
                    if (userChoice == 0)
                    {
                        userChooseBack = true;
                    }
                    else
                    {
                        m_MenuItems[userChoice - 1].PrintUserChoice(); //fix it
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Something was wrong. Let's try again: ");
                }
            }
            while (!userChooseBack);
        }

        //public void ShowOperation()
        //{
        //    m_ShowOperation.Show();
        //}
    }
}
