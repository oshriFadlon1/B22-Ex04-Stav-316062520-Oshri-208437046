using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class ShowVersion
    {
        public static void ShowCurrentVersion()
        {
            OperatingSystem os = Environment.OSVersion;
            Version ver = os.Version;
            Console.WriteLine("Version: {0} ", ver);
        }
    }
}
