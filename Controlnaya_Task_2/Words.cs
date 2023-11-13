using System;

public static class IntExtensions
{
    public static string ToWords(this int number)
    {
        if (number < 1 || number > 10)
        {
            throw new ArgumentOutOfRangeException("Число должно быть от 1 до 10");
        }

        string[] units = { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

        int unit = number % 10;
        int ten = (number / 10) % 10;


        string result = "";


        if (ten == 1 && unit > 0)
        {
            result += teens[unit] + " ";
        }
        else
        {
            if (ten > 0)
            {
                result += $"{tens[ten]} ";
            }

            if (unit > 0)
            {
                result += $"{units[unit]} ";
            }
        }

        return result.Trim();
    }
}

class Program
{
    static void Main()
    {
        int number = 1234;
        string result = number.ToWords();
        Console.WriteLine(result); // Выведет "один три два четыре"
    }
}

