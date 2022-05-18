using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    public class Program
    {

        public static void Main()
        {
            // start menu interface
            Ex04.Menus.Interfaces.MainMenu mainMenu = new Ex04.Menus.Interfaces.MainMenu();
            ItemBuilder.InitMenu(mainMenu);
            mainMenu.Show();

            // start menu delegates
        }
    }
}
