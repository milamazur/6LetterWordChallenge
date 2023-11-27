using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {    
        var fileName = Path.Combine(Environment.CurrentDirectory, "input.txt");

        List<string> words = new List<string>();
        using (StreamReader sr = new StreamReader(fileName))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                words.Add(line);
            }
        }

        PrintCombinationsTwoWords(words, 6);
    }

    static void PrintCombinationsTwoWords (List<string> words, int wordLength)
    {
        for (int i = 0; i < words.Count; i++)
        {
            for (int j = i + 1; j < words.Count; j++)
            {
                string combined = words[i] + words[j];

                if (combined.Length == wordLength && words.Contains(combined))
                {
                    Console.WriteLine($"{words[i]}+{words[j]}={combined}");
                }
            }
        }
    }
}
