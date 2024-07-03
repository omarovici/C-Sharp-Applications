using System.Text;

namespace Demo;

class Program
{
    static void Main1(string[] args)
    {
        #region Named and Default Input Parameters

        // Print();
        // PrintRepeatableSymbols(7,"#");
        #endregion

        #region Passing By Value & Refrence [Value Type]

        // int num01 = 10, num02 = 20;
        // Console.WriteLine($"Num01 = {num01}, Num02 = {num02}");
        // Swap( ref num01, ref num02) ;
        // Console.WriteLine($"Num01 = {num01}, Num02 = {num02}");

        #endregion

        #region Passing By Value & Reference [Reference Type] (Edit Item Value) & (Ref Keyword)
        // int[] numbers = { 5, 7, 8, 9, 1 };
        //
        // Console.WriteLine($"Outer Before: {numbers.GetHashCode()}");
        // Console.WriteLine(SumArrayElements(numbers));
        //
        // Console.WriteLine($"Outer After: {numbers.GetHashCode()}");
        //
        // Console.WriteLine(numbers[0]);
        #endregion
        
        #region Passing By Out
        // int X = 10, Y = 20, sum, multiply;
        //
        // SumAndMultiply(X, Y, out sum, out multiply);
        //
        // Console.WriteLine(sum);
        // Console.WriteLine(multiply);

        #endregion
        
        #region Params
        //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

        // int result = SumArrayElements (1, 2, 3, 4, 5, 6, 7, 8);
        //
        // Console.WriteLine(result);
        #endregion

        #region Enum

        // Enum.TryParse(typeof(DaysOfWeek), Console.ReadLine(), false, out object day)
        //
        // Console.WriteLine(day);


        #endregion

    }

    #region Named and Default Input Parameters

    // static void Print()
    // {
    //     for (int i = 0; i < 10; i++)
    //         Console.Write("$");
    // }
    //
    // static void PrintRepeatableSymbols(int countOfIterations, string symbol)
    // {
    //     for (int i = 0; i < countOfIterations; i++)
    //         Console.Write(symbol);
    // }
    
    #endregion
    
    #region Passing By Value & Refrence [Value Type]

    // static void Swap(ref int x , ref int y)
    // {
    //     int temp = x;
    //     x = y;
    //     y = temp;
    // }

    #endregion
    
    #region Passing By Value & Reference [Reference Type] (Edit Item Value) & (Ref Keyword)

    // static int SumArrayElements(int[] numbers)
    // {
    //     Console.WriteLine($"Inner Before: {numbers.GetHashCode()}");
    //     int sum = 0;
    //
    //     numbers[0] = 100;
    //     Console.WriteLine($"Inner After: {numbers.GetHashCode()}");  
    //
    //     for (int i = 0; i < numbers.Length; i++)
    //     {
    //         sum += numbers[i];
    //     }
    //
    //     return sum;
    // }
    #endregion

    #region Pass By Out

    // static void SumAndMultiply(int x, int y, out int sum, out int multiply)
    //
    // {
    //     sum = x + y;
    //     multiply = x * y;
    // }

    #endregion
    
    #region By Value Vs Reference Vs Out
    // By Value => Read Only
    // By Reference => Read First then Write
    // By Out => Write First then Read
    #endregion
    
    #region Params
    // static int SumArrayElements(params int[] numbers)
    // {
    //     int sum = 0;
    //     foreach (int num in numbers)
    //     {
    //         sum += num;
    //     }
    //     return sum;
    // }

    #endregion

    #region Enum
    
    // public enum DaysOfWeek
    // {
    //     Sunday = 1,
    //     Monday,
    //     Tuesday,
    //     Wednesday,
    //     Thursday,
    //     Friday,
    //     Saturday
    // }

    #endregion
    
}