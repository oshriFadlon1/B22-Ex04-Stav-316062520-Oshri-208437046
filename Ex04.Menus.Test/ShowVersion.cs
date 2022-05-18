using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    public class ShowVersion : IListener
    {
        public static void ShowCurrentVersion()
        {
            OperatingSystem os = Environment.OSVersion;
            Version ver = os.Version;
            Console.WriteLine("Version: {0} ", ver);
        }

        void IListener.Invoke()
        {
            ShowCurrentVersion();
        }
    }
}
