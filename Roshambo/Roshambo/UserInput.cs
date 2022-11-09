using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roshambo
{
    public class UserInput
    {
        public static string HumanPlayerInputString()
        {
            Console.WriteLine("What is your name?");
            string userInput = Console.ReadLine();

            return userInput;
        }

        public static int HumanPlayerInputInt()
        {
            Console.WriteLine("Please enter a number 1 - 3");
            int userInput = int.Parse(Console.ReadLine());

            return userInput;
        }
    }
}