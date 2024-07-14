namespace Assignment_03_OOP;

public class Point3D : IComparable , ICloneable
{
    internal double Point1;
    internal double Point2;
    internal double Point3;

    public Point3D(double point1, double point2, double point3)
    {
        Point1 = point1;
        Point2 = point2;
        Point3 = point3;
    }

    public Point3D(double point1, double point2) : this(point1, point2, 0)
    {
    }

    public Point3D(double point1) : this(point1, 0, 0)
    {
    }

    public Point3D() : this(0, 0, 0)
    {
    }

    public override string ToString()
    {
        return $"Point Coordinates: ({Point1},{Point2},{Point3})";
    }
    
    public object Clone()
    {
        return new Point3D
        {
            Point1 = this.Point1,
            Point2 = this.Point2,
            Point3 = this.Point3
        };
    }

    public int CompareTo(object? obj)
    {
        Point3D point = obj as Point3D;
        int ans = Point1.CompareTo(point.Point1);
        if (ans==0)
        {
            ans = Point2.CompareTo(point.Point2);
        }

        return ans;
    }
}