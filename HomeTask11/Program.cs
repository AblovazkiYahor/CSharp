using System;

public class Math
{
    //Метод для сложения двух чисел
    public double Add(double a, double b)
    {
        return a + b;
    }

    //Метод для вычитания второго числа из первого
    public double Subtract(double a, double b)
    {
        return a - b;
    }

    //Метод для умножения двух чисел
    public double Multiply(double a, double b)
    {
        return a * b;
    }

    //Метод для деления первого числа на второе
    public double Divide(double a, double b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Ошибка: Нельзя делить на ноль.");
            return double.NaN; //Возвращает ошибку
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Math calculator = new Math();

        double num1 = 5;
        double num2 = 12;

        Console.WriteLine($"Сумма: {calculator.Add(num1, num2)}");
        Console.WriteLine($"Разность: {calculator.Subtract(num1, num2)}");
        Console.WriteLine($"Произведение: {calculator.Multiply(num1, num2)}");
        Console.WriteLine($"Частное: {calculator.Divide(num1, num2)}");
    }
}