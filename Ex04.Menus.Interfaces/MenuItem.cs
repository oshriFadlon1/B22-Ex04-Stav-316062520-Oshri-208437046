using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : IShow
    {
        private string m_ItemName;
        private List<MenuItem> m_MenuItems;
        private ILeafMethod m_LeafMethod;

        public MenuItem(string i_ItemName)
        {
            m_ItemName = i_ItemName;
            m_MenuItems = new List<MenuItem>();
            m_LeafMethod = null;
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

        public ILeafMethod LeafMethod
        {
            get
            {
                return m_LeafMethod;
            }

            set
            {
                m_LeafMethod = value;
            }
        }

        public void AddItemsToListMenuItems(MenuItem i_MenuItem)
        {
            m_MenuItems.Add(i_MenuItem);
        }

        public void RemoveItemsFromListMenuItems(MenuItem i_MenuItem)
        {
            m_MenuItems.Remove(i_MenuItem);
        }

        public void PrintItemMenu()
        {
            Console.Clear();
            Console.WriteLine("**{0}**", m_ItemName);
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
            if (m_MenuItems.Count > 0) // check if the list is empty
            {
                Show();
            }
            else
            {
                m_LeafMethod.InvokeMethod();
                System.Threading.Thread.Sleep(2000);
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
                        m_MenuItems[userChoice - 1].PrintUserChoice();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Something was wrong. Let's try again: ");
                    System.Threading.Thread.Sleep(1500);
                }
            }
            while (!userChooseBack);
        }
    }
}
