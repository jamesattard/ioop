
Random random = new Random();
char choice;

do
{
    Console.WriteLine("Choose Rock (r), Paper (p), or Scissors (s): ");
    char userChoice = Console.ReadKey().KeyChar;
    Console.WriteLine();

    int computerChoice = random.Next(1, 4);
    char computerSymbol;

    if (computerChoice == 1)
        computerSymbol = 'r';
    else if (computerChoice == 2)
        computerSymbol = 'p';
    else
        computerSymbol = 's';

    Console.WriteLine("Computer chose: "+computerSymbol);

    if (userChoice == computerSymbol)
    {
        Console.WriteLine("It's a tie!");
    }
    else if ((userChoice == 'r' && computerSymbol == 's') ||
             (userChoice == 'p' && computerSymbol == 'r') ||
             (userChoice == 's' && computerSymbol == 'p'))
    {
        Console.WriteLine("You win!");
    }
    else
    {
        Console.WriteLine("You lose!");
    }

    Console.Write("Do you want to play again? (y/n): ");
    choice = Console.ReadKey().KeyChar;
    Console.WriteLine();

} while (choice == 'y' || choice == 'Y');
