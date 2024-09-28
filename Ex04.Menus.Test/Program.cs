namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            InterfacesTestRunner interfacesTestRunner = new InterfacesTestRunner();
            interfacesTestRunner.CreateInterfaceMenu();
            EventsTestRunner EventTestRunner = new EventsTestRunner();
            EventsTestRunner.CreateEventsMenu();
        }
    }
}