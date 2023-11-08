namespace HomeTask12
{
    public class Car
    {
        //Поля класса
        private string color;
        private string type;
        private int year;

        //Конструктор класса
        public Car(string color, string type, int year)
        {
            this.color = color;
            this.type = type;
            this.year = year;
        }

        //Метод для запуска автомобиля
        public void StartCar()
        {
            Console.WriteLine("Автомобиль заведён");
        }

        //Метод для отключения автомобиля
        public void StopCar()
        {
            Console.WriteLine("Автомобиль заглушен");
        }

        //Метод для установки года выпуска автомобиля
        public void SetYear(int year)
        {
            this.year = year;
        }

        //Метод для установки типа автомобиля
        public void SetType(string type)
        {
            this.type = type;
        }

        //Метод для установки цвета автомобиля
        public void SetColor(string color)
        {
            this.color = color;
        }

        //Метод для получения информации о машине
        public void GetCarInfo()
        {
            Console.WriteLine($"Год выпуска: {year}");
            Console.WriteLine($"Тип: {type}");
            Console.WriteLine($"Цвет: {color}");
        }
    }
}

