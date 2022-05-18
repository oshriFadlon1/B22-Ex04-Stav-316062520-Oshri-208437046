using System;

namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    public class CountSpaces : ILeafMethod
    {
        public static void CountSpacesInString()
        {
            int countSpaces = 0;
            Console.WriteLine("Please enter your sentence: ");
            string userString = Console.ReadLine();

            foreach (char character in userString)
            {
                if (character == ' ')
                {
                    countSpaces++;
                }
            }

            Console.WriteLine("There are {0} Spaces in your sentence.", countSpaces);
        }

        void ILeafMethod.InvokeMethod()
        {
            CountSpacesInString();
        }
    }
}
