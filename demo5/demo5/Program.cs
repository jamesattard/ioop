using System.Collections.Generic;

List<string> myList = new List<string>();
myList.Add("Mercury");
myList.Add("Venus");
myList.Add("Mars");
myList.Add("Jupiter");
myList.Add("Saturn");
myList.Add("Uranus");
myList.Add("Neptune");
myList.Add("Pluto");

Console.WriteLine("First Item in list:" + myList[0]);
Console.WriteLine("Last Item in list:" + myList[myList.Count - 1]);

Console.WriteLine();
Console.WriteLine("Whole List:");
foreach (string item in myList)
{
    Console.WriteLine(item);
}
Console.WriteLine();

Console.WriteLine("After Inserting Earth in 3rd place");
myList.Insert(2, "Earth");

foreach (string item in myList)
{
    Console.WriteLine(item);
}

Console.WriteLine();
Console.WriteLine("After Removing Pluto");
myList.Remove("Pluto");

foreach (string item in myList)
{
    Console.WriteLine(item);
}

//replacing
Console.WriteLine();
Console.WriteLine("After Replacing Mars");
int marsIndex = myList.IndexOf("Mars");
myList[marsIndex] = "The Red Planet";

foreach (string item in myList)
{
    Console.WriteLine(item);
}

//searching
Console.WriteLine();
Console.WriteLine("Checking if Moon is in the list");

if (myList.Contains("Moon"))
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");