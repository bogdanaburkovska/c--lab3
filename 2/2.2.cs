using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "words.txt";

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string word;
                while ((word = sr.ReadLine()) != null)
                {
                    if (word.StartsWith("s", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Помилка: {e.Message}");
        }
    }
}
