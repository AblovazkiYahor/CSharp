class Program
{
    static void Main()
    {
        //Создание объектов различных классов
        Vehicle vehicle = new Vehicle { Weight = 1500, MaxSpeed = 200 };
        Car car = new Car { Weight = 1200, MaxSpeed = 180, NumberOfDoors = 4, FuelType = "Gasoline" };
        Truck truck = new Truck { Weight = 5000, MaxSpeed = 120, PayloadCapacity = 10000 };
        ElectricCar electricCar = new ElectricCar { Weight = 1000, MaxSpeed = 150, NumberOfDoors = 2, FuelType = "Electric", RangePerCharge = 300, ChargeLevel = 80 };

        //Вызов метода DisplayInfo() через ссылку на базовый класс
        Console.WriteLine("Calling DisplayInfo() through base class reference:");
        DisplayInfoThroughBase(vehicle);
        DisplayInfoThroughBase(car);
        DisplayInfoThroughBase(truck);
        DisplayInfoThroughBase(electricCar);

        Console.WriteLine();

        //Вызов метода DisplayInfo() через ссылку на производный класс
        Console.WriteLine("Calling DisplayInfo() through derived class reference:");
        DisplayInfoThroughDerived(vehicle);
        DisplayInfoThroughDerived(car);
        DisplayInfoThroughDerived(truck);
        DisplayInfoThroughDerived(electricCar);
    }

    static void DisplayInfoThroughBase(Vehicle vehicle)
    {
        vehicle.DisplayInfo();
    }

    static void DisplayInfoThroughDerived(Vehicle vehicle)
    {
        if (vehicle is ElectricCar)
        {
            //Используем ключевое слово new для вызова метода из ElectricCar
            ((ElectricCar)vehicle).DisplayInfo();
        }
        else
        {
            //Вызываем метод из базового класса (или переопределенный в производном классе)
            vehicle.DisplayInfo();
        }
    }
}

