using System;

List<int> marks = new List<int>();

Console.WriteLine("Input marks. Input -1 to stop");

while (true)
{
    string mark = Console.ReadLine();
    try
    {
        int markInt = Convert.ToInt32(mark);
        if (markInt == -1)
            break;
        marks.Add(markInt);
    }
    catch
    {
        Console.WriteLine("Invalid input");
    }
}

PrintAllMarks(marks);
Console.WriteLine();

Console.WriteLine("Class Average is "+CalculateAverage(marks));
Console.WriteLine();
Console.WriteLine("Converting marks to grades:");

foreach (int mark in marks)
    Console.WriteLine(mark + " -> " + GetLetterGrade(mark));


void PrintAllMarks(List<int> marks)
{   
    foreach (int mark in marks)
    {
        Console.Write(mark + ", ");
    }    
}

float CalculateAverage(List<int> marks)
{
    float sum = 0;
    foreach (int mark in marks)
    {
        sum += mark;
    }
    return sum / marks.Count;
}

char GetLetterGrade(int mark)
{
    if (mark >= 90) return 'A';
    else if (mark >= 80) return 'B';
    else if (mark >= 70) return 'C';
    else if (mark >= 60) return 'D';
    else return 'F';
}
