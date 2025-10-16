int countdownTime = 0;

do
{
    Console.Write("Enter countdown time in seconds: ");
    countdownTime = int.Parse(Console.ReadLine());
} while (countdownTime < 5);

// Use a for loop to count down
for (int i = countdownTime; i > 0; i--)
{
    Console.WriteLine(i);
    Thread.Sleep(1000); // Delay for 1 second
}

Console.WriteLine("Time's up!");