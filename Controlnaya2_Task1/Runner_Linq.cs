using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //инициализация случайными числами
        Random random = new Random();
        List<int> numbers = Enumerable.Range(1, 8).Select(_ => random.Next(1, 100)).ToList();

        //cортировка по возрастанию
        numbers.Sort();

        //выбор второй половины (или округленной вверх, если нечетное количество элементов)
        int halfCount = (int)Math.Ceiling(numbers.Count / 2.0);
        var secondHalf = numbers.Skip(halfCount).ToList();

        //сортировка по убыванию
        var sortedDescending = secondHalf.OrderByDescending(x => x);

        //возведение в квадрат каждого элемента
        var squaredNumbers = sortedDescending.Select(x => x * x).ToList();

        //вывод результата
        Console.WriteLine("Исходная коллекция: " + string.Join(", ", numbers));
        Console.WriteLine("Вторая половина, отсортированная по убыванию и возведенная в квадрат: " + string.Join(", ", squaredNumbers));
    }
}


