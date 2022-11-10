using System;
using Roshambo;



UserInput.Start();

//HumanPlayer humanPlayer = new HumanPlayer();


//Console.Clear();
//Console.WriteLine($"Hello {humanPlayer.GetName()}, please choose your opponent");
//Console.WriteLine("1.) Rock Player");
//Console.WriteLine("2.) Random Player");
//Console.WriteLine("3.) Quit\n");

//int userChoice = UserInput.HumanPlayerInputInt();
//int menu = 0;
//int battle = 0;
//Roshambo.Roshambo userWeapon;

//switch (userChoice)
//{
//    case 1:
//        Console.Clear();
//        RockPlayer rockPlayer = new RockPlayer();
//        Console.WriteLine("OPPONENT: Rock Player!");
//        userWeapon = humanPlayer.GenerateRoshambo();
//        Console.Clear();
//        Console.WriteLine($"{humanPlayer.GetName()}'s Choice: {userWeapon.ToString()}");
//        Console.WriteLine($"{rockPlayer.GetName()}'s Choice: {rockPlayer.GenerateRoshambo().ToString()}");
//        battle = UserInput.ToBattle(userWeapon, rockPlayer.GenerateRoshambo(), userChoice);
//        //Console.WriteLine(battle);
//        if (battle == 1)
//        {
//            Console.WriteLine($"{userWeapon.ToString()} beats {rockPlayer.GenerateRoshambo().ToString()} - {humanPlayer.GetName()} Won!");
//            humanPlayer.AddScore();
//        }
//        else if (battle == 2)
//        {
//            Console.WriteLine($"{rockPlayer.GenerateRoshambo().ToString()} beats {userWeapon.ToString()} - {rockPlayer.GetName()} Won!");
//            rockPlayer.AddScore();
//        }
//        else if (battle == 3)
//        {
//            Console.WriteLine("Draw!");
//        }
//        break;
//    case 2:
//        Console.Clear();
//        RandomPlayer randomPlayer = new RandomPlayer();
//        Console.WriteLine("OPPONENT: Random Player!");
//        userWeapon = UserInput.WeaponSelector();
//        Console.Clear();
//        Roshambo.Roshambo randomWeapon = randomPlayer.GenerateRoshambo();
//        Console.WriteLine($"{humanPlayer.GetName()}'s Choice: {userWeapon.ToString()}");
//        Console.WriteLine($"{randomPlayer.GetName()}'s Choice: {randomWeapon.ToString()}");
//        battle = UserInput.ToBattle(userWeapon, randomWeapon, userChoice);
//        Console.WriteLine(battle);
//        if (battle == 1)
//        {
//            Console.WriteLine($"{userWeapon.ToString()} beats {randomWeapon.ToString()} - {humanPlayer.GetName()} Won!");
//            humanPlayer.AddScore();
//        }
//        else if (battle == 2)
//        {
//            Console.WriteLine($"{randomWeapon.ToString()} beats {userWeapon.ToString()} - {randomPlayer.GetName()} Won!");
//            randomPlayer.AddScore();
//        }
//        else if (battle == 3)
//        {
//            Console.WriteLine("Draw!");
//        }
//        break;
//    case 3:
//        Console.WriteLine("Goodbye!");
//        Environment.Exit(0);
//        break;
//}




// string test = cat.GetName();

// Console.WriteLine(test);


// int test = UserInput.HumanPlayerInputInt();

// Console.WriteLine(test);
// Console.WriteLine(test);
// Console.WriteLine(test);
// Console.WriteLine(test);