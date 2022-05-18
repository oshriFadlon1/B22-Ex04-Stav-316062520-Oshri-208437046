using System;

namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    public class ShowTime : ILeafMethod
    {
        public static void ShowCurrentTime()
        {
            Console.WriteLine("The time is: {0}", DateTime.Now.ToString("HH:mm"));
        }

        void ILeafMethod.InvokeMethod()
        {
            ShowCurrentTime();
        }
    }
}
