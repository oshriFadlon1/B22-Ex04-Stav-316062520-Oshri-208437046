using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class ItemBuilder
    {
     

        public static void InitMenu(List<MenuItem> io_MenuItemsList)
        {
            MenuItem dateMenuItem = new MenuItem("Show Date");
            MenuItem timeMenuItem = new MenuItem("Show Time");

            MenuItem option1MainItem = new MenuItem("Show Date/Time");
            option1MainItem.AddItemsToListMenuItems(dateMenuItem);
            option1MainItem.AddItemsToListMenuItems(timeMenuItem);


            MenuItem spacesMenuItem = new MenuItem("Count Spaces");
            MenuItem versionMenuItem = new MenuItem("Show Version");

            MenuItem option2MainItem = new MenuItem("Version and Spaces");
            option2MainItem.AddItemsToListMenuItems(spacesMenuItem);
            option2MainItem.AddItemsToListMenuItems(versionMenuItem);

            io_MenuItemsList.Add(option1MainItem);
            io_MenuItemsList.Add(option2MainItem);

        }

        public  static void ShowTime()
        {
            Console.WriteLine("The time is: {0}:{1}", DateTime.Now.Hour.ToString(), DateTime.Now.Minute.ToString());
        }

        public static void ShowDate()
        {
            Console.WriteLine("The date is: {0}/{1}/{2}", DateTime.Today.Day.ToString(), DateTime.Today.Month.ToString(), DateTime.Today.Date.Year.ToString());
        }

        public static void CountSpaces()
        {
            int countSpaces = 0;
            Console.WriteLine("Please enter your sentence: ");
            string userString = Console.ReadLine();
            foreach(char character in userString)
            {
                if (character == ' ')
                {
                    countSpaces++;
                }
            }
            Console.WriteLine("There are {0} Spaces in your sentence.", countSpaces);
        }

        public static void ShowVersion()
        {
            OperatingSystem os = Environment.OSVersion;
            Version ver = os.Version;
            Console.WriteLine("Version: {0} ", ver);
        }

    }


}
