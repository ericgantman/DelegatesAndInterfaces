using Ex04.Menus.Interfaces;
using System;
namespace Ex04.Menus.Test
{
    internal class CountCapitals : IMenuItemExecution
    {
        public void Execute()
        {
            int numberOfCapitalLetters = 0;
            string inputFromUser;

            Console.Write("Please enter a text: ");
            inputFromUser = Console.ReadLine();
            foreach (char charInInput in inputFromUser)
            {
                if (char.IsUpper(charInInput))
                {
                    numberOfCapitalLetters++;
                }
            }

            Console.WriteLine(string.Format("There are {0} capitals in your sentence.", numberOfCapitalLetters));
        }
    }
}