
Random random = new Random();

int userGuess = 0;
int numberOfTries = 0;
string wantToContinue = "";

do
{
    int targetNumber = random.Next(1, 101); // Random number between 1 and 100
    numberOfTries = 0;

    Console.WriteLine("Welcome to the Guess the Number Game!");
    Console.WriteLine("I have selected a number between 1 and 100. Try to guess it!");

    while (true)
    {
        Console.Write("Enter your guess: ");
        userGuess = Convert.ToInt32(Console.ReadLine());
        numberOfTries++;

        if (userGuess < targetNumber)
        {
            Console.WriteLine("Too low! Try again.");
        }
        else if (userGuess > targetNumber)
        {
            Console.WriteLine("Too high! Try again.");
        }
        else
        {
            Console.WriteLine("Congratulations! You guessed the number after " + numberOfTries + " tries!");

            break; // Exit the loop when the guess is correct
        }
    }

    Console.Write("Want to play again (yes/no): ");
    wantToContinue = Console.ReadLine();

} while (wantToContinue == "yes");

Console.WriteLine("Thanks for playing!");