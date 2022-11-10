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

        public static int ToBattle(Roshambo humanPlayerWeapon, Roshambo secondPlayerWeapon, int secondPlayerType)
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

        public static void Start()
        {

            HumanPlayer humanPlayer = new HumanPlayer();
            RockPlayer rockPlayer = new RockPlayer();
            RandomPlayer randomPlayer = new RandomPlayer();

            UserInput.Menu(humanPlayer, rockPlayer, randomPlayer);

        }

        public static void Menu(HumanPlayer humanPlayer, RockPlayer rockPlayer, RandomPlayer randomPlayer)
        {
            Console.Clear();
            Console.WriteLine($"Hello {humanPlayer.GetName()}, please choose your opponent");
            Console.WriteLine("1.) Rock Player");
            Console.WriteLine("2.) Random Player");
            Console.WriteLine("3.) Quit\n");

            int userChoice = UserInput.HumanPlayerInputInt();

            UserInput.Test(userChoice, humanPlayer, rockPlayer, randomPlayer);
        }

        public static void Test(int userChoice, HumanPlayer humanPlayer, RockPlayer rockPlayer, RandomPlayer randomPlayer)
        {
            int battle = 0;
            Roshambo userWeapon;
            bool isValidInput = false;

            switch (userChoice)
            {
                

                case 1:
                    Console.Clear();
                    
                    Console.WriteLine("OPPONENT: Rock Player!\n");
                    userWeapon = humanPlayer.GenerateRoshambo();
                    Console.Clear();
                    Console.WriteLine($"{humanPlayer.GetName()}'s Choice: {userWeapon.ToString()}");
                    Console.WriteLine($"{rockPlayer.GetName()}'s Choice: {rockPlayer.GenerateRoshambo().ToString()}");
                    battle = UserInput.ToBattle(userWeapon, rockPlayer.GenerateRoshambo(), userChoice);
                    if (battle == 1)
                    {
                        Console.WriteLine($"{userWeapon.ToString()} beats {rockPlayer.GenerateRoshambo().ToString()} - {humanPlayer.GetName()} Won!");
                        humanPlayer.AddScore();
                    }
                    else if (battle == 2)
                    {
                        Console.WriteLine($"{rockPlayer.GenerateRoshambo().ToString()} beats {userWeapon.ToString()} - {rockPlayer.GetName()} Won!");
                        rockPlayer.AddScore();
                    }
                    else if (battle == 3)
                    {
                        Console.WriteLine("Draw!");
                    }

                    Console.WriteLine("\nScores:");
                    Console.WriteLine($"{humanPlayer.GetName()} - {humanPlayer.GetScore()}");
                    Console.WriteLine($"{rockPlayer.GetName()} - {rockPlayer.GetScore()}");

                    Console.WriteLine("\nWould you like to play again? [y]/[n]: ");
                    do
                    {

                        string playAgain = Console.ReadLine().ToLower();

                        if (playAgain == "y" || playAgain == "yes")
                        {
                            Console.Clear();
                            Menu(humanPlayer, rockPlayer, randomPlayer);
                        }
                        else if (playAgain == "n" || playAgain == "no")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid Input. Would you like to play again? Please enter either a 'y' or an 'n'.\n");
                        }
                    } while (isValidInput == false);

                    break;
                case 2:
                    Console.Clear();
                    
                    Console.WriteLine("OPPONENT: Random Player!\n");
                    userWeapon = UserInput.WeaponSelector();
                    Console.Clear();
                    Roshambo randomWeapon = randomPlayer.GenerateRoshambo();
                    Console.WriteLine($"{humanPlayer.GetName()}'s Choice: {userWeapon.ToString()}");
                    Console.WriteLine($"{randomPlayer.GetName()}'s Choice: {randomWeapon.ToString()}");
                    battle = UserInput.ToBattle(userWeapon, randomWeapon, userChoice);
                    if (battle == 1)
                    {
                        Console.WriteLine($"{userWeapon.ToString()} beats {randomWeapon.ToString()} - {humanPlayer.GetName()} Won!");
                        humanPlayer.AddScore();
                    }
                    else if (battle == 2)
                    {
                        Console.WriteLine($"{randomWeapon.ToString()} beats {userWeapon.ToString()} - {randomPlayer.GetName()} Won!");
                        randomPlayer.AddScore();
                    }
                    else if (battle == 3)
                    {
                        Console.WriteLine("Draw!");
                    }

                    Console.WriteLine("\nScores:");
                    Console.WriteLine($"{humanPlayer.GetName()} - {humanPlayer.GetScore()}");
                    Console.WriteLine($"{randomPlayer.GetName()} - {randomPlayer.GetScore()}");

                    Console.WriteLine("\nWould you like to play again? [y]/[n]: ");
                    do
                    {

                        string playAgain = Console.ReadLine().ToLower();

                        if (playAgain == "y" || playAgain == "yes")
                        {
                            Console.Clear();
                            Menu(humanPlayer, rockPlayer, randomPlayer);
                        }
                        else if (playAgain == "n" || playAgain == "no")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid Input. Would you like to play again? Please enter either a 'y' or an 'n'.\n");
                        }
                    } while (isValidInput == false);
                    break;
                case 3:
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;
            }





        }





    }
}
