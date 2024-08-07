namespace Assignment_03_LINQ;
using static Assignment_03_LINQ.ListGenerator;
class Program
{
    static void Main(string[] args)
    {
        #region LINQ - Partitioning Operators

        // 1. Get the first 3 orders from customers in Washington
        // var first3Orders = CustomerList.Where(customer => customer.City == "Washington")
        //     .SelectMany(customer => customer.Orders).Take(3);
        // foreach (var index in first3Orders)
        // {
        //     Console.WriteLine(index);
        // }
        
        // 2. Get all but the first 2 orders from customers in Washington.
        // var skipFirst2Orders = CustomerList.Where(customer => customer.City == "Washington")
        //     .SelectMany(customer => customer.Orders).Skip(2);
        // foreach (var index in skipFirst2Orders)
        // {
        //     Console.WriteLine(index);
        // }
        
        // 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
        // int [] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
        // var untitHitPosition = numbers.TakeWhile((num, index) => num > index);
        // foreach (var index in untitHitPosition)
        // {
        //     Console.WriteLine(index);
        // }
        
        // 4.Get the elements of the array starting from the first element divisible by 3.
        // int [] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
        // var skipUntilDiv3 = numbers.SkipWhile(num => num % 3 != 0);
        // foreach (var index in skipUntilDiv3)
        // {
        //     Console.WriteLine(index);
        // }

        // 5. Get the elements of the array starting from the first element less than its position.
        // int [] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
        // var firtLessPosition = numbers.SkipWhile((num, index) => num > index);
        // foreach (var index in firtLessPosition)
        // {
        //     Console.WriteLine(index);
        // }

        #endregion
    }
}