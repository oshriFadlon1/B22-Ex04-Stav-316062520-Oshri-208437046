using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class Program
    {

        public static void Main()
        {
            // start menu interface
            Ex04.Menus.Interfaces.MainMenu mainMenu = new Ex04.Menus.Interfaces.MainMenu();
            Ex04.Menus.Interfaces.ItemBuilder.ShowDate();
            Ex04.Menus.Interfaces.ItemBuilder.ShowTime();
            Ex04.Menus.Interfaces.ItemBuilder.ShowVersion();
            Ex04.Menus.Interfaces.ItemBuilder.CountSpaces();
            mainMenu.Show();
            // start menu delegates
        }
    }
}
