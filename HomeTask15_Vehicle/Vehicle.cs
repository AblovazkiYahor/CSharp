//Базовый класс Vehicle
class Vehicle
{
    public double Weight { get; set; }
    public int MaxSpeed { get; set; }

    //Виртуальный метод DisplayInfo()
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Vehicle - Weight: {Weight}, Max Speed: {MaxSpeed}");
    }
}