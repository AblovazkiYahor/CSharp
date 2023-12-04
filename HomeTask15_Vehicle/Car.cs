//Производный класс Car
class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
    public string FuelType { get; set; }

    //Переопределение метода DisplayInfo()
    public override void DisplayInfo()
    {
        Console.WriteLine($"Car - Weight: {Weight}, Max Speed: {MaxSpeed}, Doors: {NumberOfDoors}, Fuel Type: {FuelType}");
    }
}

