using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    public class ItemBuilder
    {
        public static void InitMenu(MainMenu io_MainMenu)
        {
            MenuItem dateMenuItem = new MenuItem("Show Date");
            dateMenuItem.ShowOperation = new ShowDate();

            MenuItem timeMenuItem = new MenuItem("Show Time");
            timeMenuItem.ShowOperation = new ShowTime();

            MenuItem option1MainItem = new MenuItem("Show Date/Time");

            option1MainItem.AddItemsToListMenuItems(dateMenuItem);
            option1MainItem.AddItemsToListMenuItems(timeMenuItem);

            MenuItem spacesMenuItem = new MenuItem("Count Spaces");
            spacesMenuItem.ShowOperation = new CountSpaces();

            MenuItem versionMenuItem = new MenuItem("Show Version");
            versionMenuItem.ShowOperation = new ShowVersion();

            MenuItem option2MainItem = new MenuItem("Version and Spaces");
            option2MainItem.AddItemsToListMenuItems(spacesMenuItem);
            option2MainItem.AddItemsToListMenuItems(versionMenuItem);

            io_MainMenu.AddItemsToListMenuItems(option1MainItem);
            io_MainMenu.AddItemsToListMenuItems(option2MainItem);
        }
    }
}
