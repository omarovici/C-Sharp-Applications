namespace Assignment_01_OOP;

class Program
{
    static void Main(string[] args)
    {
        // 1. Define a struct “Person” with properties “Name” and 
        // “Age.” Create an array of three “Person” objects and 
        // populate it with data. Then, write a C# program to 
        // display the details of all the persons in the array.

        #region Problem 1

        // Person[] p = { new Person(), new Person(), new Person() };
        // for (int i = 0; i < 3; i++)
        // {
        //     Console.Write($"Enter the name of person {i+1} : ");
        //     string s = Console.ReadLine();
        //     p[i].name = s;
        //     Console.Write($"Enter the age of person {i+1} : ");
        //     int a = int.Parse(Console.ReadLine());
        //     p[i].Age = a;
        // }
        // Console.WriteLine();
        // for (int i = 0; i < 3; i++)
        // {
        //     Console.WriteLine($"\nName of Person {i+1} : {p[i].name} - Age of Person {i+1} : {p[i].Age}");
        // }


        #endregion
        
        // 2. Create a struct called “Point” to represent a 2D point 
        //     with properties “X” and “Y.” Write a C# program that 
        // takes two points as input from the user and calculates 
        //     the distance between them.

        #region Problem 2

        // Point p1 = new Point();
        // Point p2 = new Point();
        //
        // Console.Write("Enter the value of X1 : ");
        // p1.x = double.Parse(Console.ReadLine());
        // Console.Write("Enter the value of Y1 : ");
        // p1.y = double.Parse(Console.ReadLine());
        //
        // Console.Write("Enter the value of X2 : ");
        // p2.x = double.Parse(Console.ReadLine());
        // Console.Write("Enter the value of Y2 : ");
        // p2.y = double.Parse(Console.ReadLine());
        //
        // double Distance = Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        // Console.WriteLine($"The distance between 2 points is {Distance}");

        #endregion
        
        // 3. Create a struct called “Person” with properties “Name” and 
        //     “Age.” Write a C# program that takes details of 3 persons as 
        //     input from the user and displays the name and age of the 
        //     oldest person

        #region Problem 3

        // Person[] p = { new Person(), new Person(), new Person() };
        // for (int i = 0; i < 3; i++)
        // {
        //     Console.Write($"Enter the name of person {i+1} : ");
        //     string s = Console.ReadLine();
        //     p[i].name = s;
        //     Console.Write($"Enter the age of person {i+1} : ");
        //     int a = int.Parse(Console.ReadLine());
        //     p[i].Age = a;
        // }
        //
        // Person old = p[0];
        // for (int i = 0; i < 3; i++)
        // {
        //     if (p[i].Age > old.Age) old = p[i];
        // }
        //
        // Console.WriteLine($"\nThe oldest person is {old.name} & age is {old.Age}.");

        #endregion
    }

    struct Person
    {
        internal string name;
        internal int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value >= 0 ? value : 0; }
        }

    }

    struct Point
    {
        internal double x;
        internal double y;
    }
}