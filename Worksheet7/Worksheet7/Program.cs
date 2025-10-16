List<int> lottoNumbers = new List<int>();
List<int> userTicket = new List<int>();

// Collecting Lotto Numbers
while (lottoNumbers.Count < 5)
{
    Console.Write("Enter a lotto number (1-90): ");

    try
    {
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);

        if (number >= 1 && number <= 90 && !lottoNumbers.Contains(number))
        {
            lottoNumbers.Add(number);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
    catch
    {
        Console.WriteLine("Invalid input");
    }
}

Console.Write("The drawn lotto numbers are: ");

foreach (int number in lottoNumbers)
    Console.Write(number+" ");

Console.WriteLine();

// Display the first lotto number
Console.WriteLine("The first drawn lotto number is: "+lottoNumbers[0]);