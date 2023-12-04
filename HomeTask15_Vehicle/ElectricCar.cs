//Производный класс ElectricCar
class ElectricCar : Car
{
    public double RangePerCharge { get; set; }
    public int ChargeLevel { get; set; }

    //Использование ключевого слова new для переопределения метода DisplayInfo()
    public new void DisplayInfo()
    {
        Console.WriteLine($"ElectricCar - Weight: {Weight}, Max Speed: {MaxSpeed}, Doors: {NumberOfDoors}, Fuel Type: {FuelType}, Range per Charge: {RangePerCharge}, Charge Level: {ChargeLevel}");
    }
}

