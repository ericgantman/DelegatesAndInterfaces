using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfacesTestRunner
    {
        public void CreateInterfaceMenu()
        {
            MainMenu mainMenuInterfaces = new MainMenu("Interfaces Main Menu");
            MenuItem versionAndCapitalsMenu = new MenuItem("Version and Capitals");
            MenuItem showDateTimeMenu = new MenuItem("Show Date/Time");

            versionAndCapitalsMenu.AddSubItem(new MenuItem("Show Version", new ShowVersion()));
            versionAndCapitalsMenu.AddSubItem(new MenuItem("Count Capitals", new CountCapitals()));
            mainMenuInterfaces.RootMenu.AddSubItem(versionAndCapitalsMenu);
            showDateTimeMenu.AddSubItem(new MenuItem("Show Time", new ShowTime()));
            showDateTimeMenu.AddSubItem(new MenuItem("Show Date", new ShowDate()));
            mainMenuInterfaces.RootMenu.AddSubItem(showDateTimeMenu);
            mainMenuInterfaces.Show();
        }
    }
}