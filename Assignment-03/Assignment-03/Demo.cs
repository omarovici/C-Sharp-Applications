using System.Text;

namespace Demo;

class Program
{
    static void Main2(string[] args)
    {
        #region String VS StringBuilder

        // string name01 = "Ahmed";
        // string name02 = "Ali";
        //
        // Console.WriteLine(name01.GetHashCode());
        // Console.WriteLine(name02.GetHashCode());
        //
        // name01 = name02;
        // Console.WriteLine(name01.GetHashCode());
        // Console.WriteLine(name02.GetHashCode());
        //
        // name01 = "Hossam";
        // Console.WriteLine(name01.GetHashCode());
        //
        // name01 += " Ibrahim";
        // Console.WriteLine(name01.GetHashCode());
        // String is immutable

        // StringBuilder
        // StringBuilder message = new StringBuilder("Hello, ");
        // Console.WriteLine(message.GetHashCode());
        // message.Append("Omar Khalid");
        // Console.WriteLine(message.GetHashCode());
        //
        // for (int i = 0; i < 100; i++)
        // {
        //     message.Append("Omar Khalid");
        //     Console.WriteLine(message.GetHashCode());
        // }
        // StringBuilder is immutable

        #endregion

        #region One Dimensional Array

        // int[] numbers;

        // int X = int.Parse(Console.ReadLine());

        // numbers = new int[3];
        // numbers[0] = 1;
        // numbers[1] = 2;
        // numbers[2] = 3;
        // numbers[0] = 4;
        // Console.WriteLine(numbers[0]);
        // Array is fixed size
        // int[] numbers02 = new int[3] { 4, 5, 6 };
        // int[] numbers03 = new int[] { 4, 5, 6 };
        // int[] numbers04 = { 4, 5, 6 };
        //
        // Console.WriteLine($"Size = {numbers04.Length}, Number Of Dimensions = {numbers04.Rank}");
        //
        // foreach (int i in numbers) Console.WriteLine(i);
        
        // Shallow Copy VS Deep Copy
        // int[] numbers01 = { 1, 2, 3, 4, 5 };
        // int[] numbers02 = { 6, 7, 8, 9, 10 };
        //
        // Console.WriteLine(numbers01.GetHashCode());
        // Console.WriteLine(numbers02.GetHashCode());
        
        // numbers02 = numbers01;
        //
        // Console.WriteLine(numbers01.GetHashCode());
        // Console.WriteLine(numbers02.GetHashCode());
        //
        // foreach (var i in numbers02) Console.WriteLine(i);

        // numbers02 = (int[])numbers01.Clone();
        //
        // Console.WriteLine(numbers01.GetHashCode());
        // Console.WriteLine(numbers02.GetHashCode());
        
        
        // for (int i = 0; i < numbers01.Length; i++)
        // {
        //     numbers02[i] = numbers01[i];
        // }

        #endregion

        #region Two Dimensional Array

        // int[,] marks = new int[3, 4];
        //
        // for (int i = 0; i < marks.GetLength(0); i++)
        // {
        //     Console.WriteLine($"Please Enter The Marks Of Student Number {i+1}");
        //     for (int j = 0; j < marks.GetLength(1); j++)
        //     {
        //         Console.WriteLine($"Please Enter The Marks Of Subject Number {j+1}");
        //         int mark = int.Parse(Console.ReadLine());
        //
        //         marks[i, j] = mark;
        //     }
        // }
        //
        // for (int i = 0; i < marks.GetLength(0); i++)
        // {
        //     Console.WriteLine($"The Marks Of Student Number {i+1}");
        //     for (int j = 0; j < marks.GetLength(1); j++)
        //     {
        //         Console.WriteLine($"The Marks Of Subject Number {j+1}");
        //         Console.WriteLine(marks[i,j]);
        //     }
        // }
        //
        // --------------------------------------------------------------------------------
        // int[,] marks = new int[3, 4];
        // bool flag = false;
        // for (int i = 0; i < marks.GetLength(0); i++)
        // {
        //     Console.WriteLine($"Please Enter The Marks Of Student Number {i+1}");
        //     for (int j = 0; j < marks.GetLength(1);)
        //     {
        //         Console.WriteLine($"Please Enter The Marks Of Subject Number {j+1}");
        //         flag = int.TryParse(Console.ReadLine(),out marks[i,j]);
        //
        //         j = (flag == true) ? ++j : j;
        //     }
        // }
        //
        // for (int i = 0; i < marks.GetLength(0); i++)
        // {
        //     Console.WriteLine($"The Marks Of Student Number {i+1}");
        //     for (int j = 0; j < marks.GetLength(1); j++)
        //     {
        //         Console.WriteLine($"The Marks Of Subject Number {j+1}");
        //         Console.WriteLine(marks[i,j]);
        //     }
        // }
        
        #endregion
        // Self-study try to find a way to read the 2d with less complexity

        #region Boxing VS Unboxing

        // Casting Between Object(Reference Type) and any value Type
        // object obj = new object();
        // int X = 10;
        // obj = X;
        // obj = 'A';
        // obj = "Ahmed";
        
        // Cast From int(Value Type) to object (Reference Type) => Implicitly
        // Parent = Child
        // Safe Casting
        // Boxing

        // int Y = (int)obj;
        // Cast From object (Reference Type) to int(Value Type) => Explicitly
        // Child = Parent
        // Insafe Casting
        // UnBoxing

        #endregion

        #region Nullable Types

        // Value Types that allow null value
        // Assign null to value type variable
        // int? X = null;
        // X = 10;
        //
        // int Y;
        //
        // if (X == null) 
        //     X = 0;
        //
        // Y = (int)X;
        //
        // if (!X.HasValue)
        //     X = 0;
        //
        // Y = (int)X;
        //
        // Y = X.HasValue ? X.Value : 0;
        
        // Null Coalescing Operator => C# 8.0
        // int? Z = 20;
        // Y = X ?? Z ?? 0;
        //
        #endregion
        
        #region Null Propagation Operator
        
        // int X = default; // 0
        // int[] arr = default; // Null
        // for (int i = 0; (arr != null) && i < arr.Length; i++) 
        //     Console.WriteLine(i);
        // for (int i = 0; i < arr?.Length; i++) 
        //     Console.WriteLine(i);
        #endregion

        #region Implicitly Typed Local Variable [var - dynamic]
        
        // Var
        // var X = 2.25;
        // X = "Ahmed"; // Cannot convert source type 'string' to target type 'double'
        // Strongly Typed: Cannot change its data type once determined ()
        // Must be Initialized
        // Cannot be null
        
        
        // Dynamic
        // dynamic y = null;
        // y = 10;
        // y = "Ahmed";

        #endregion

    }
}