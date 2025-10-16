using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Distinction 85 - 100
            //Merit 72 - 84
            //Pass 45 - 71
            //Fail 0 - 44

            Console.Write("Mark: ");
            int mark = Convert.ToInt32(Console.ReadLine());
            string grade = string.Empty;

            if (mark >= 0 && mark < 45)
                grade = "Fail";
            else if (mark < 72)
                grade = "Pass";
            else if (mark < 85)
                grade = "Merit";
            else if (mark <= 100)
                grade = "Distinction";
            else
            {
                Console.WriteLine($"Input was invalid.");
                grade = "Invalid";
            }

            if (grade != "Invalid")
                Console.WriteLine($"Your grade is {grade}");
            Console.ReadKey();
        }
    }
}
