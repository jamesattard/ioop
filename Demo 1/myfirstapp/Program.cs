int numberToGuess;
int userGuess;
string name;
      
Random random = new Random();

numberToGuess = random.Next(1, 11);
        
Console.WriteLine("Welcome to the Number Guessing Game!"+numberToGuess);
Console.Write("Enter your name: ");
name = Console.ReadLine(); //ignore warning for now

Console.WriteLine("I have selected a number between 1 and 10. Can you guess it?");

Console.Write("Enter your guess: ");
userGuess = Convert.ToInt32(Console.ReadLine());
      
if (userGuess != numberToGuess)
{
    Console.WriteLine("Sorry "+name+", Incorrect!");
}         
else
{
    Console.WriteLine("Congratulations "+name+"! You've guessed the number!");
}
     