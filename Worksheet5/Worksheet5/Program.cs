Console.WriteLine("You will have a total of 10 Math questions. Good luck!");
Random generator = new Random();
int num1;
int num2;
int op;
List<int> correctAnswers = new List<int>();
List<int> userAnswers = new List<int>();

for (int i = 0; i < 10; i++)
{
    num1 = generator.Next(0,10);
    num2 = generator.Next(0,10);
    op = generator.Next(0,2);

    if (op == 0)
    {
        Console.WriteLine(num1 + "+" + num2);
        correctAnswers.Add(num1+num2);
    }
    else
    {
        Console.WriteLine(num1 + "*" + num2);
        correctAnswers.Add(num1*num2);
    }

    Console.WriteLine("Answer: ");
    try
    {
        userAnswers.Add(Convert.ToInt32(Console.ReadLine()));
    }
    catch {
        Console.WriteLine("Invalid input. Defaulted to 0");
        userAnswers.Add(0);
    }
}

Console.WriteLine("Quiz Results:");
int score = 0;
Console.WriteLine("Input\tCorrect");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(userAnswers[i]+ "\t" + correctAnswers[i]);
    if (userAnswers[i] == correctAnswers[i])
        score++;
}

Console.WriteLine();
Console.WriteLine("Total: "+score+" out of 10.");


