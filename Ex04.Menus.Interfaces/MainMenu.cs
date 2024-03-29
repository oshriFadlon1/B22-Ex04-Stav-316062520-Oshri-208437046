﻿using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : IShow
    {
        private List<MenuItem> m_MenuItems;

        public MainMenu()
        {
            m_MenuItems = new List<MenuItem>();
        }

        public void AddItemsToListMenuItems(MenuItem i_MenuItem)
        {
            m_MenuItems.Add(i_MenuItem);
        }

        public void RemoveItemsToListMenuItems(MenuItem i_MenuItem)
        {
            m_MenuItems.Remove(i_MenuItem);
        }

        public void Show()
        {
            bool userChooseExit = false;
            do
            {
                PrintMainMenu();
                try
                {
                    Console.WriteLine("Enter your request: ");
                    int userChoice = int.Parse(Console.ReadLine());
                    if (userChoice == 0)
                    {
                        userChooseExit = true;
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
            while (!userChooseExit);
        }

        // print main menu
        public void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("**Interface Main Menu**");
            Console.WriteLine("----------------------");
            for (int i = 0; i < m_MenuItems.Count; i++)
            {
                Console.WriteLine("{0} -> {1}", i + 1, m_MenuItems[i].ItemName);
            }

            Console.WriteLine("0 - > Exit");
            Console.WriteLine("----------------------");
        }
    }
}
