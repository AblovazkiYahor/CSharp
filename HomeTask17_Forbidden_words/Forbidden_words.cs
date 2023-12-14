using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Введите путь к файлу: ");
        string filePath = Console.ReadLine();

        try
        {
            //Чтение запрещенных слов из файла
            string[] forbiddenWords = File.ReadAllText("forbidden_words.txt").ToLower().Split(' ');

            //Чтение текста из файла
            string content = File.ReadAllText(filePath);

            //Замена запрещенных слов
            foreach (string forbiddenWord in forbiddenWords)
            {
                string pattern = $@"\b{forbiddenWord}\b";
                content = Regex.Replace(content, pattern, new string('*', forbiddenWord.Length), RegexOptions.IgnoreCase);
            }

            //Вывод отредактированного текста
            Console.WriteLine("\nОтредактированный текст:");
            Console.WriteLine(content);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}



