using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть текст:");
        string text = Console.ReadLine();

        // Розділити текст на слова
        string[] words = text.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        // Підрахунок кількості слів, що починаються з голосної літери
        int vowelStartCount = 0;
        foreach (string word in words)
        {
            if (word.Length > 0 && IsVowel(word[0]))
            {
                vowelStartCount++;
            }
        }
        Console.WriteLine($"Кількість слів, що починаються з голосної літери: {vowelStartCount}");

        // Вивести слова з непарною кількістю приголосних літер
        Console.WriteLine("Слова з непарною кількістю приголосних літер:");
        foreach (string word in words)
        {
            if (CountConsonants(word) % 2 != 0)
            {
                Console.WriteLine(word);
            }
        }
    }

    // Перевірка, чи є літера голосною
    static bool IsVowel(char letter)
    {
        return "aeiouAEIOUаеиоуіяюєїАЕИОУІЯЮЄЇ".Contains(letter);
    }

    // Підрахунок кількості приголосних літер у слові
    static int CountConsonants(string word)
    {
        return Regex.Matches(word, @"[бвгґджзйклмнпрстфхцчшщБВГҐДЖЗЙКЛМНПРСТФХЦЧШЩ]").Count;
    }
}
