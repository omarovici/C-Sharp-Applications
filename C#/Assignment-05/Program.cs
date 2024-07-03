namespace Assignment_05;

class Program
{
    static void Main(string[] args)
    {
        // 1- Create an enum called "WeekDays" with the days of the week
        // (Monday to Sunday) as its members. Then, write a C# program that
        // prints out all the days of the week using this enum.

        #region Problem 1

        // WeekDays[] day = (WeekDays[])Enum.GetValues(typeof(WeekDays));
        // foreach (var i in day)
        // {
        //     Console.WriteLine(i);
        // }

        #endregion
        
        // 2. Create an enum called "Season" with the four seasons (Spring,
        // Summer, Autumn, Winter) as its members. Write a C# program that
        // takes a season name as input from the user and displays the
        // corresponding month range for that season. Note range for seasons
        // (spring march to may, summer june to August, autumn September to
        // November, winter December to February)

        #region Problem 2

        // Console.WriteLine("Enter the season name: ");
        // Enum.TryParse(typeof(Season), Console.ReadLine(), true, out var s);
        //
        // switch (s)
        // {
        //     case Season.Spring:
        //         Console.WriteLine("March to May");
        //         break;
        //     case Season.Summer:
        //         Console.WriteLine("June to August");
        //         break;
        //     case Season.Autumn:
        //         Console.WriteLine("September to November");
        //         break;
        //     case Season.Winter:
        //         Console.WriteLine("December to February");
        //         break;
        //     default:
        //         Console.WriteLine("Invalid");
        //         break;
        // }

        #endregion
        
        // 3- Assign the following Permissions (Read, write, Delete, Execute) in a
        //     form of Enum.
        //     ● Create Variable from previous Enum to Add and Remove
        //     Permission from variable, check if specific Permission is
        //     existed inside variable

        #region Problem 3

        // Employee employee = new Employee();
        // Console.Write("Enter the value: ");
        // int x = int.Parse(Console.ReadLine());
        // employee.permission = (Permission)x;
        // Console.WriteLine($"The permissions that the employee has : {employee.permission}");
        
        #endregion

        // 4. Create an enum called "Colors" with the basic colors (Red, Green, Blue)
        //     as its members. Write a C# program that takes a color name as input from
        //     the user and displays a message indicating whether the input color is a
        //     primary color or not

        #region Problem 4

        // Console.WriteLine("Enter a color name: ");
        // string x = Console.ReadLine();
        //
        // if (Enum.TryParse(x, true, out Colors color))
        //     Console.WriteLine($"{x} is a primary color.");
        // else
        //     Console.WriteLine($"{x} is not a primary color.");

        #endregion

    }
    [Flags]
    public enum Permission
    {
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
    public enum WeekDays
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    
    public enum Season
    {
        Spring = 1,
        Summer,
        Autumn,
        Winter
    }
    
    enum Colors
    {
        Red = 1,
        Green,
        Blue
    }

    internal class Employee
    {
        public int ID;
        public string Name;
        public Permission permission;
    }
    
}