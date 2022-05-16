using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : IShowMenu
    {
        private List<MenuItem> m_MenuItems = new List<MenuItem>();


        public void Show()
        {
            Console.WriteLine("done");
        }
    }
}
