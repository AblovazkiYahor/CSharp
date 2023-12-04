//Производный класс Truck
class Truck : Vehicle
{
    public double PayloadCapacity { get; set; }

    //Переопределение метода DisplayInfo()
    public override void DisplayInfo()
    {
        Console.WriteLine($"Truck - Weight: {Weight}, Max Speed: {MaxSpeed}, Payload Capacity: {PayloadCapacity}");
    }
}

