using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    public class ShowTime : IListener
    {
        public static void ShowCurrentTime()
        {
            Console.WriteLine("The time is: {0}:{1}", DateTime.Now.Hour.ToString(), DateTime.Now.Minute.ToString());
        }

        void IListener.Invoke()
        {
            ShowCurrentTime();
        }
    }
}
