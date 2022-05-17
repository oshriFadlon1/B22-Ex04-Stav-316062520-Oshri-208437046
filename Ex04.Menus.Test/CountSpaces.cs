using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class CountSpaces
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
    }
}
