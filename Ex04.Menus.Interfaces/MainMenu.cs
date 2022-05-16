using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : MenuItem, IShowMenu
    {
        //private List<MenuItem> m_MenuItems = new List<MenuItem>();

        public void Show()
        {
            Console.WriteLine("done");
        }
        // print main menu
    }
}
