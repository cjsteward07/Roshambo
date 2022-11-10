using System;
using Roshambo;

// RockPlayer test = new RockPlayer();


// string test1 = test.GenerateRoshambo();

// Console.WriteLine(test1);


// RockPlayer test = new RockPlayer();

HumanPlayer humanPlayer = new HumanPlayer();

// Roshambo.Roshambo test1 = test.GenerateRoshambo();

// Console.WriteLine(test1);

Console.WriteLine($"Hello {humanPlayer.GetName()}, please choose your opponent");
Console.WriteLine("1.) Rock Player");
Console.WriteLine("2.) Random Player");
Console.WriteLine("3.) Quit\n");

int userChoice = UserInput.HumanPlayerInputInt();
int menu = 0;
int battle = 0;
Roshambo.Roshambo userWeapon;

switch (userChoice)
{
    case 1:
        RockPlayer rockPlayer = new RockPlayer();
        Console.WriteLine("OPPONENT: Rock Player!");
        userWeapon = UserInput.WeaponSelector();
        battle = UserInput.ToBattle(userWeapon, rockPlayer.GenerateRoshambo(), "rock");
        Console.WriteLine(battle);
        break;
    case 2:
        RandomPlayer randomPlayer = new RandomPlayer();
        Console.WriteLine("OPPONENT: Random Player!");
        userWeapon = UserInput.WeaponSelector();
        battle = UserInput.ToBattle(userWeapon, randomPlayer.GenerateRoshambo(), "random");
        Console.WriteLine(battle);




        // Console.WriteLine(userWeapon.ToString());
        break;


}




// string test = cat.GetName();

// Console.WriteLine(test);


// int test = UserInput.HumanPlayerInputInt();

// Console.WriteLine(test);
// Console.WriteLine(test);
// Console.WriteLine(test);
// Console.WriteLine(test);