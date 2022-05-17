using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class ShowDate
    {
        public static void ShowCurrentDate()
        {
            Console.WriteLine("The date is: {0}/{1}/{2}", DateTime.Today.Day.ToString(), DateTime.Today.Month.ToString(), DateTime.Today.Date.Year.ToString());
        }
    }
}
