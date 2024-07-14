namespace Assignment_03_OOP;

public class Rectangle : IRectangle
{
    public double Area()
    {
        return Length * Width;
    }

    public void DisplayShapeInfo()
    {
        Console.WriteLine("This is Rectangle");
    }

    public Rectangle(double length , double width)
    {
        Length = length;
        Width = width;
    }
    public double Length { get; set; }
    public double Width { get; set; }
}