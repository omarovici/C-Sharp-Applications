namespace Assignment_03_OOP;

public class Circle : ICircle
{
    public double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public void DisplayShapeInfo()
    {
        Console.WriteLine("This is Circle");
    }

    public Circle(double radius)
    {
        Radius = radius;
    }
    public double Radius { get; set; }
}