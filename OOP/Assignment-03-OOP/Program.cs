namespace Assignment_03_OOP;

class Program
{
    static void Main(string[] args)
    {
        #region First Project

        // Point3D P = new Point3D(10, 10, 10);
        // Console.WriteLine(P.ToString());
        
        //------------------------------------------------------------------
        
        // Point3D P1 = Read("P1");
        // Point3D P2 = Read("P2");
        //
        // Console.WriteLine(P1.ToString());
        // Console.WriteLine(P2.ToString());
        //
        // if(P1==P2) Console.WriteLine("EQUAL");
        // else Console.WriteLine("NOT EQUAL");
        // // It will not work, to work we must use operator overloading
        
        //------------------------------------------------------------------

        // Point3D[] P = new[]
        // {
        //     new Point3D(7, 2, 1),
        //     new Point3D(5, 2, 1),
        //     new Point3D(4, 2, 1),
        //     new Point3D(1, 2, 1),
        //     new Point3D(6, 2, 1),
        //     new Point3D(-1, 2, 1),
        //     new Point3D(-1, 1, 1),
        //
        // };
        // Array.Sort(P);
        // foreach (var i in P)
        // {
        //     Console.WriteLine(i);
        // }
        
        //------------------------------------------------------------------

        // Point3D Ptest1 = new Point3D(1,5,10);
        // Point3D Ptest2 = (Point3D)Ptest1.Clone();
        //
        // Console.WriteLine(Ptest1.ToString());
        // Console.WriteLine(Ptest2.ToString());

        #endregion

        #region Second Project

        // Circle circle = new Circle(10);
        // Console.WriteLine($"The area of the Circle = {circle.Area()}");
        // circle.DisplayShapeInfo();
        //
        // Rectangle rectangle = new Rectangle(5,5);
        // Console.WriteLine($"The area of the Rectangle = {rectangle.Area()}");
        // rectangle.DisplayShapeInfo();


        #endregion

        #region Third Project

        // Duration D =new Duration (1,10,15);
        // Console.WriteLine(D.ToString());
        //
        // Duration D1 =new Duration (3600);
        // Console.WriteLine(D1.ToString());
        //
        // Duration D2 =new Duration (7800);
        // Console.WriteLine(D2.ToString());
        //
        // Duration D3 =new Duration (666);
        // Console.WriteLine(D3.ToString());
        //
        // D3 = D1 + D2;
        // Console.WriteLine(D3.ToString());
        //
        // D3 = D1 + 7800;
        // Console.WriteLine(D3.ToString());
        //
        // D3 = 666 + D3;
        // Console.WriteLine(D3.ToString());
        //
        // D3 = ++D1;
        // Console.WriteLine(D3.ToString());
        //
        // D3 = --D2;
        // Console.WriteLine(D3.ToString());
        //
        // D1 = D1 - D2;
        // Console.WriteLine(D1.ToString());
        //
        // Console.WriteLine(D1>D2);
        // Console.WriteLine(D1<=D2);
        // if (D1)
        // {
        //     Console.WriteLine("True");
        // }
        //
        // DateTime Obj = (DateTime)D1;
        // Console.WriteLine(Obj.ToString());

        #endregion
    }

    public static Point3D Read(string point)
    {
        double x, y, z;
        bool check = true;
        
            Console.Write($"Enter the first point in {point} : ");
            check = double.TryParse(Console.ReadLine(), out x);
            if(!check) Console.WriteLine("Wrong Value , Please enter the value again");
            
            Console.WriteLine();

            Console.Write($"Enter the second point in {point} : ");
            check = double.TryParse(Console.ReadLine(), out y);
            if(!check) Console.WriteLine("Wrong Value , Please enter the value again");
            
            Console.WriteLine();

            Console.Write($"Enter the third point in {point} : ");
            check = double.TryParse(Console.ReadLine(), out z);
            if(!check) Console.WriteLine("Wrong Value , Please enter the value again");
            
            Console.WriteLine();

        return new Point3D(x, y, z);
    }
}
