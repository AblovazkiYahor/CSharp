namespace HomeTask12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем объект класса Car
            Car myCar = new Car("Белый", "Седан", 2011);

            //Выводим информацию о машине
            Console.WriteLine("Информация о моей машине:");
            myCar.GetCarInfo();

            //Запускаем и отключаем машину
            myCar.StartCar();
            myCar.StopCar();

            //Устанавливаем новый год выпуска, тип и цвет
            myCar.SetYear(2023);
            myCar.SetType("Кроссовер");
            myCar.SetColor("Синий");

            //Выводим обновленную информацию о машине
            Console.WriteLine("Информация о моей машине после обновления:");
            myCar.GetCarInfo();
        }
    }
}

