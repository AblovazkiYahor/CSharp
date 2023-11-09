using System;

class Sphere
{
    private double radius;
    private double x;
    private double y;
    private double z;

    //Конструкторы
    public Sphere()
    {
        radius = 1;
        x = 0;
        y = 0;
        z = 0;
    }

    public Sphere(double radius)
    {
        this.radius = radius;
        x = 0;
        y = 0;
        z = 0;
    }

    public Sphere(double radius, double x, double y, double z)
    {
        this.radius = radius;
        this.x = x;
        this.y = y;
        this.z = z;
    }

    //Свойство Radius
    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    //Метод для вычисления объема сферы
    public double GetVolume()
    {
        return (4 / 3) * Math.PI * Math.Pow(radius, 3);
    }

    //Метод для вычисления площади внешней поверхности сферы
    public double GetSquare()
    {
        return 4 * Math.PI * Math.Pow(radius, 2);
    }

    //Метод для получения координат центра сферы
    public string GetCenter()
    {
        return $"{x} {y} {z}";
    }

    //Метод для изменения координат центра сферы
    public void SetCenter(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    //Метод для проверки, находится ли точка внутри сферы
    public bool IsPointInside(double testX, double testY, double testZ)
    {
        double distance = Math.Sqrt(Math.Pow(testX - x, 2) + Math.Pow(testY - y, 2) + Math.Pow(testZ - z, 2));
        return distance <= radius;
    }
}



