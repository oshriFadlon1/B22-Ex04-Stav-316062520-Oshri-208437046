namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            // start menu interface
            Interfaces.MainMenu mainMenuInterfaces = new Interfaces.MainMenu();
            ItemBuilder.InitMenuInterface(mainMenuInterfaces);
            mainMenuInterfaces.Show();

            System.Console.Clear();

            // start menu delegates
            Delegates.MainMenu mainMenuDelegates = new Delegates.MainMenu();
            ItemBuilder.InitMenuDelegate(mainMenuDelegates);
            mainMenuDelegates.Show();
        }
    }
}
