using Ex04.Menus.Interfaces;
using System;
namespace Ex04.Menus.Test
{
    internal class ShowTime : IMenuItemExecution
    {
        public void Execute()
        {
            Console.WriteLine(string.Format("The Hour is: {0}", DateTime.Now.ToLongTimeString()));
        }
    }
}