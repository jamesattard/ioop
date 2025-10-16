
for (int i = 1; i <= 10; i++)   //simplest for loop (just printing 1-10)
{
    Console.WriteLine(i);
}

//----------------------------------------------------------------------
Console.Write("Enter a number to count up to: ");
int number = int.Parse(Console.ReadLine());
for (int i = 1; i <= number; i++)   
{
    Console.WriteLine(i);
}

//----------------------------------------------------------------------

Console.Write("Enter a number to generate its multiplication table: ");
number = int.Parse(Console.ReadLine());

Console.WriteLine("Multiplication Table for number: "+number);
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(number+" x "+i+" = "+(number*i));
}