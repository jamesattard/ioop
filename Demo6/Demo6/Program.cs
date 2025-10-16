Console.Write("Please enter your name and surname: ");
string fullName = Console.ReadLine();

int spaceIndex = fullName.IndexOf(' ');

if (spaceIndex != -1)
{
    char firstInitial = fullName[0];
    char surnameInitial = fullName[spaceIndex + 1];
    Console.WriteLine("Your initials are: " + firstInitial + "." + surnameInitial + ".");

    string name = fullName.Substring(0, spaceIndex);   
    Console.WriteLine("Your name is: " + name);

    // Step 5: Find the length of the name
    int nameLength = name.Length;
    Console.WriteLine("Your name has " + nameLength + " letters.");
}
else
{
    Console.WriteLine("Invalid input");
}