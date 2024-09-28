using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test
{
    internal class ShowVersion : IMenuItemExecution
    {
        public void Execute()
        {
            Console.WriteLine("App Version: 24.2.4.9504");
        }
    }
}