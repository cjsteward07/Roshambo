using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Roshambo;

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
            bool isValidInput = false;
            int userInput = 0;
            do
            {
                Console.Write("Please enter a number 1 -3: ");
                do
                {
                    isValidInput = int.TryParse(Console.ReadLine(), out userInput);
                    if (isValidInput == false)
                    {
                        Console.Write("Invalid input. Please enter a valid number: ");
                    }
                } while (isValidInput == false);
            }
            while (userInput < 1 || userInput > 3);

            return userInput;

         
             
        
        }

        public static Roshambo WeaponSelector()
        {
            Console.WriteLine("Please select your weapon of choice:");
            Console.WriteLine($"1.) {Roshambo.Rock.ToString()}");
            Console.WriteLine($"2.) {Roshambo.Paper.ToString()}");
            Console.WriteLine($"3.) {Roshambo.Scissors.ToString()}");

            int userChoice = HumanPlayerInputInt();
            
            switch (userChoice)
            {
                case 1:
                    return Roshambo.Rock;
                    break;
                case 2:
                    return Roshambo.Paper;
                    break;
                case 3:
                    return Roshambo.Scissors;
                    break;
            }
            return Roshambo.Rock;
        } 

        public static int ToBattle(Roshambo humanPlayerWeapon, Roshambo secondPlayerWeapon, string secondPlayerType)
        {
            if (humanPlayerWeapon == secondPlayerWeapon)
            {
                return 3;
            }
            else if (humanPlayerWeapon == Roshambo.Rock && secondPlayerWeapon == Roshambo.Paper)
            {
                return 2;
            }
            else if (humanPlayerWeapon == Roshambo.Rock && secondPlayerWeapon == Roshambo.Scissors)
            {
                return 1;
            }
            else if (humanPlayerWeapon == Roshambo.Paper && secondPlayerWeapon == Roshambo.Rock)
            {
                return 1;
            }
            else if (humanPlayerWeapon == Roshambo.Paper && secondPlayerWeapon == Roshambo.Scissors)
            {
                return 2;
            }
            else if (humanPlayerWeapon == Roshambo.Scissors && secondPlayerWeapon == Roshambo.Rock)
            {
                return 2;
            }
            else if (humanPlayerWeapon == Roshambo.Scissors && secondPlayerWeapon == Roshambo.Paper)
            {
                return 1;
            }
            return 4;







        }
    }
}