using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        //Путь к входному файлу
        string inputFilePath = "input.txt";

        // Путь к выходному файлу
        string outputFilePath = "output.txt";

        try
        {
            // Считываем все строки из входного файла
            string[] lines = File.ReadAllLines(inputFilePath);

            // Создаем или перезаписываем выходной файл
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                // Обрабатываем каждую строку
                foreach (string line in lines)
                {
                    // Получаем самое частое слово и количество его повторений
                    var mostCommonWordInfo = GetMostCommonWord(line);

                    // Записываем результат в выходной файл
                    writer.WriteLine($"{mostCommonWordInfo.Word} {mostCommonWordInfo.Count}");
                }
            }

            Console.WriteLine("Результат записан в файл: " + outputFilePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }

    // Метод для нахождения самого частого слова и его количества повторений в строке
    static (string Word, int Count) GetMostCommonWord(string input)
    {
        // Разбиваем строку на слова
        string[] words = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        // Создаем словарь для подсчета повторений каждого слова
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        // Подсчитываем количество повторений каждого слова
        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
            else
            {
                wordCount[word] = 1;
            }
        }

        // Находим самое частое слово и его количество повторений
        var mostCommonWord = wordCount.OrderByDescending(pair => pair.Value).FirstOrDefault();

        return (mostCommonWord.Key, mostCommonWord.Value);
    }
}


