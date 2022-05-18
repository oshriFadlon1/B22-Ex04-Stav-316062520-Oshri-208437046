namespace Ex04.Menus.Test
{
    using Ex04.Menus;

    public class ItemBuilder
    {
        public static void InitMenuInterface(Interfaces.MainMenu io_MainMenu)
        {
            Interfaces.MenuItem dateMenuItem = new Interfaces.MenuItem("Show Date");
            dateMenuItem.LeafMethod = new ShowDate();

            Interfaces.MenuItem timeMenuItem = new Interfaces.MenuItem("Show Time");
            timeMenuItem.LeafMethod = new ShowTime();

            Interfaces.MenuItem option1MainItem = new Interfaces.MenuItem("Show Date/Time");

            option1MainItem.AddItemsToListMenuItems(dateMenuItem);
            option1MainItem.AddItemsToListMenuItems(timeMenuItem);

            Interfaces.MenuItem spacesMenuItem = new Interfaces.MenuItem("Count Spaces");
            spacesMenuItem.LeafMethod = new CountSpaces();

            Interfaces.MenuItem versionMenuItem = new Interfaces.MenuItem("Show Version");
            versionMenuItem.LeafMethod = new ShowVersion();

            Interfaces.MenuItem option2MainItem = new Interfaces.MenuItem("Version and Spaces");
            option2MainItem.AddItemsToListMenuItems(spacesMenuItem);
            option2MainItem.AddItemsToListMenuItems(versionMenuItem);

            io_MainMenu.AddItemsToListMenuItems(option1MainItem);
            io_MainMenu.AddItemsToListMenuItems(option2MainItem);
        }

        public static void InitMenuDelegate(Delegates.MainMenu io_MainMenu)
        {
            Delegates.MenuItem dateMenuItem = new Delegates.MenuItem("Show Date");
            dateMenuItem.m_GotLeafMethod += new Delegates.LeafMethod(ShowDate.ShowCurrentDate);

            Delegates.MenuItem timeMenuItem = new Delegates.MenuItem("Show Time");
            timeMenuItem.m_GotLeafMethod += new Delegates.LeafMethod(ShowTime.ShowCurrentTime);

            Delegates.MenuItem option1MainItem = new Delegates.MenuItem("Show Date/Time");

            option1MainItem.AddItemsToListMenuItems(dateMenuItem);
            option1MainItem.AddItemsToListMenuItems(timeMenuItem);

            Delegates.MenuItem spacesMenuItem = new Delegates.MenuItem("Count Spaces");
            spacesMenuItem.m_GotLeafMethod += new Delegates.LeafMethod(CountSpaces.CountSpacesInString);

            Delegates.MenuItem versionMenuItem = new Delegates.MenuItem("Show Version");
            versionMenuItem.m_GotLeafMethod += new Delegates.LeafMethod(ShowVersion.ShowCurrentVersion);

            Delegates.MenuItem option2MainItem = new Delegates.MenuItem("Version and Spaces");
            option2MainItem.AddItemsToListMenuItems(spacesMenuItem);
            option2MainItem.AddItemsToListMenuItems(versionMenuItem);

            io_MainMenu.AddItemsToListMenuItems(option1MainItem);
            io_MainMenu.AddItemsToListMenuItems(option2MainItem);
        }
    }
}
