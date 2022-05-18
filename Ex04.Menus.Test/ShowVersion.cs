using System;

namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    public class ShowVersion : ILeafMethod
    {
        public static void ShowCurrentVersion()
        {
            Console.WriteLine("Version: 22.2.4.8950");
        }

        void ILeafMethod.InvokeMethod()
        {
            ShowCurrentVersion();
        }
    }
}
