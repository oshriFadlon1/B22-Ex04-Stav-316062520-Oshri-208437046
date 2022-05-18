using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    public class ShowDate : IListener
    {
        public static void ShowCurrentDate()
        {
            Console.WriteLine("The date is: {0}/{1}/{2}", DateTime.Today.Day.ToString(), DateTime.Today.Month.ToString(), DateTime.Today.Date.Year.ToString());
        }

        void IListener.Invoke()
        {
            ShowCurrentDate();
        }
    }
}
