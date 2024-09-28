using Ex04.Menus.Interfaces;
using System;
namespace Ex04.Menus.Test
{
    internal class ShowDate : IMenuItemExecution
    {
        public void Execute()
        {
            Console.WriteLine(string.Format("Current Date: {0}", DateTime.Now.ToShortDateString()));
        }
    }
}
