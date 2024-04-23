using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Читання тексту з файлу input.txt
        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt";

        try
        {
            string text = File.ReadAllText(inputFilePath);

            // Обробка тексту
            string processedText = RemoveWordsWithSecondVowel(text);

            // Запис обробленого тексту у файл output.txt
            File.WriteAllText(outputFilePath, processedText);

            Console.WriteLine("Результати були успішно записані у файл output.txt.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Помилка: {e.Message}");
        }
    }

    // Метод для видалення слів, передостання літера яких голосна
    static string RemoveWordsWithSecondVowel(string text)
    {
        string[] words = text.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        string pattern = @"[aeiouyAEIOUY]";
        string result = "";

        foreach (string word in words)
        {
            if (Regex.Matches(word, pattern).Count >= 2) // Якщо в слові є хоча б дві голосні літери
            {
                string lastChar = word.Substring(word.Length - 2, 1);
                if (!IsVowel(lastChar[0])) // Якщо передостання літера не є голосною
                {
                    result += word + " ";
                }
            }
            else
            {
                result += word + " ";
            }
        }

        return result.Trim();
    }

    // Перевірка, чи є літера голосною
    static bool IsVowel(char letter)
    {
        return "aeiouyAEIOUY".Contains(letter);
    }
}
