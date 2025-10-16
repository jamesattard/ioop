// Predefined list of words
List<string> wordList = new List<string>
        {
            "cat", "hat", "bat", "rat", "mat", "flat",
            "dog", "frog", "log", "jog", "smog",
            "tree", "free", "see", "bee", "key",
            "light", "fight", "night", "sight", "might"
        };

Console.Write("Enter a word to find rhymes: ");
string inputWord = Console.ReadLine();
inputWord = inputWord.ToLower();

// Find rhymes
List<string> rhymes = new List<string>();

// Get the last two characters of the input word for rhyme matching
string rhymePart = inputWord.Substring(inputWord.Length - 2, 2);

foreach (string word in wordList)
{
    string wordRhymePart = word.Substring(word.Length - 2, 2);

    if (rhymePart == wordRhymePart)
    { rhymes.Add(word); }
}

if (rhymes.Count > 0)
{
    Console.WriteLine($"Words that rhyme with '{inputWord}':");
    foreach (string rhyme in rhymes)
    {
        Console.WriteLine(rhyme);
    }
}
else
{
    Console.WriteLine($"No rhymes found for '{inputWord}'.");
}
