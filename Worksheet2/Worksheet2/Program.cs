
// Introduction
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Welcome to the Character Creator!");
Console.Write("Enter your character's name: ");
string characterName = Console.ReadLine();

// Set initial points
int totalPoints = 10;
int strength = 0;
int agility = 0;
int intelligence = 0;

Console.WriteLine("Allocate your points.");

Console.WriteLine("Strength: ");
strength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Agility: ");
agility = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Intelligence: ");
intelligence = Convert.ToInt32(Console.ReadLine());

int sum = strength + agility + intelligence;

if (strength == 0 || agility == 0 || intelligence == 0 || sum != 10)
{
    Console.WriteLine("Wrong point allocation!");
}
else
{
    Console.WriteLine("Character Created: " + characterName);
    Console.WriteLine("Strength: " + strength);
    Console.WriteLine("Agility: " + agility);
    Console.WriteLine("Intelligence: " + intelligence);

    Console.WriteLine("Character creation complete! Press any key to exit.");    
}

        
        

