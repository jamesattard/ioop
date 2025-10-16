       // Input: Read marks from the user
        Console.Write("Enter the theory mark: ");
        int theoryMark = int.Parse(Console.ReadLine());

        Console.Write("Enter the practical mark: ");
        int practicalMark = int.Parse(Console.ReadLine());

        // Validation of marks
        bool theoryPass = theoryMark >= 50;
        bool practicalPass = practicalMark >= 50;
        int totalMarks = theoryMark + practicalMark;

        // Output: Determine pass/fail status
        if (theoryPass && practicalPass && totalMarks >= 125)
        {
            Console.WriteLine("Congratulations! You have passed the piano test.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you have failed the piano test.");
        }

