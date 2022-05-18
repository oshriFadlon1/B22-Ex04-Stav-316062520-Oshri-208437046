using System;

namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    public class ShowDate : ILeafMethod
    {
        public static void ShowCurrentDate()
        {
            Console.WriteLine("The date is: {0}/{1}/{2}", DateTime.Today.Day.ToString(), DateTime.Today.Month.ToString(), DateTime.Today.Date.Year.ToString());
        }

        void ILeafMethod.InvokeMethod()
        {
            ShowCurrentDate();
        }
    }
}
