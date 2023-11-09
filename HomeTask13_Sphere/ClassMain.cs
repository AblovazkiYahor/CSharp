class Program
{
    static void Main()
    {
        Sphere sphere1 = new Sphere(); //Создаем сферу с единичным радиусом и центром в начале координат
        Sphere sphere2 = new Sphere(3); //Создаем сферу с радиусом 3 и центром в начале координат
        Sphere sphere3 = new Sphere(2, 1, 2, 3); //Создаем сферу с радиусом 2 и заданными координатами центра

        //Изменяем координаты центра сферы
        sphere1.SetCenter(1, 2, 3);

        //Проверяем, находится ли точка внутри сферы
        double testX = 2;
        double testY = 2;
        double testZ = 2;
        bool isInside = sphere2.IsPointInside(testX, testY, testZ);

        Console.WriteLine("Сфера 1: Радиус = " + sphere1.Radius);
        Console.WriteLine("Сфера 2: Радиус = " + sphere2.Radius);
        Console.WriteLine("Сфера 3: Радиус = " + sphere3.Radius + ", Центр = " + sphere3.GetCenter());
        Console.WriteLine("Объем сферы 2: " + sphere2.GetVolume());
        Console.WriteLine("Площадь поверхности сферы 2: " + sphere2.GetSquare());

        if (isInside)
        {
            Console.WriteLine($"Точка ({testX}, {testY}, {testZ}) находится внутри сферы 2.");
        }
        else
        {
            Console.WriteLine($"Точка ({testX}, {testY}, {testZ}) не находится внутри сферы 2.");
        }
    }
}

