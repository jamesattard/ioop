using System;

string sequence = "ABC"; // The sequence to remember
Console.WriteLine("Remember this sequence: " + sequence);
System.Threading.Thread.Sleep(5000); // Wait for 5 seconds

Console.Clear(); // Clear the console
Console.WriteLine("Now, type the sequence you remember:");
string userInput = Console.ReadLine();

if (userInput == sequence)
{
    Console.WriteLine("Correct! You have a good memory.");
}
else
{
    Console.WriteLine("Oops! The correct sequence was " + sequence);
}
