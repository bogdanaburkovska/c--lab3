using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "words.txt";
        int count = 0;

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                for (int i = 0; i < 10; i++)
                {
                    string word = sr.ReadLine();
                    if (word != null && word.StartsWith("s", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(word);
                        count++;
                    }
                }
            }

            Console.WriteLine($"Загальна кількість слів, які починаються з 's': {count}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Помилка: {e.Message}");
        }
    }
}
