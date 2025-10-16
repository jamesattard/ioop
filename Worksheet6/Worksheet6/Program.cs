using System.Collections.Generic;

List<string> names = new List<string>();

string input;

while (true)
{
    Console.WriteLine("Enter a name: ");
    input = Console.ReadLine();

    if (input == "stop")
        break;

    if (!names.Contains(input))
        names.Add(input);
    else
        Console.WriteLine("Duplicate Name. Not added.");
}

foreach (string name in names)
    Console.WriteLine(name);


Random generator = new Random();
int rand = generator.Next(0, names.Count);

Console.WriteLine("The lucky winner is: " + names[rand]);

names.RemoveAt(rand);

rand = generator.Next(0, names.Count);

Console.WriteLine("The 2nd winner is: " + names[rand]);

