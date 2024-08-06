namespace Assignment_01_LINQ;
using static Assignment_01_LINQ.ListGenerator;
 
class Program
{
    static void Main(string[] args)
    {
        #region 1-LINQ - Restriction Operators

        // // 1. Find all products that are out of stock.
        // var outOfStockProducts = ProductList.Where(product => product.UnitsInStock == 0);
        // foreach (var product in outOfStockProducts)
        // {
        //     Console.WriteLine(product);
        // }
        
        // // 2. Find all products that are in stock and cost more than 3.00 per unit.
        // var inStockAndCost3 = ProductList.Where(product => product.UnitsInStock > 0 && product.UnitPrice > 3.00M);
        // foreach (var product in inStockAndCost3)
        // {
        //     Console.WriteLine(product);
        // }
        
        // // 3. Returns digits whose name is shorter than their value.
        // String [] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        // var digits = Arr.Where((digit, index) => digit.Length < index);
        // foreach (var digit in digits)
        // {
        //     Console.WriteLine(digit);
        // }

        #endregion

        #region 2-LINQ - Ordering Operators

        // // 1. Sort a list of products by name
        // var orderdProducts = ProductList.OrderBy(product => product.ProductName);
        // foreach (var product in orderdProducts)
        // {
        //     Console.WriteLine(product);
        // }
        
        // 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
        // String [] Arr = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};
        // Array.Sort(Arr, CaseInsensitiveComparer.Compare);
        // foreach (var word in Arr)
        // {
        //     Console.WriteLine(word);
        // }
        
        // // 3. Sort a list of products by units in stock from highest to lowest.
        // var orderdProducts = ProductList.OrderByDescending(product => product.UnitsInStock);
        // foreach (var product in orderdProducts)
        // {
        //     Console.WriteLine(product);
        // }
        
        // //4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
        // String [] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        // var sortedArr = Arr.OrderByDescending(digit => digit.Length).ThenBy(digit => digit).ToArray();
        // foreach (var digit in sortedArr)
        // {
        //     Console.WriteLine(digit);
        // }
        
        
        
        #endregion

        #region 3-LINQ – Transformation Operators
        
        // // 1. Return a sequence of just the names of a list of products.
        // var justNamesOfTheProducts = ProductList.Select(product => product.ProductName);
        // foreach (var name in justNamesOfTheProducts)
        // {
        //     Console.WriteLine(name);
        // }
        
        // // 2. Produce a sequence of the uppercase and lowercase versions of each word in
        // // the original array (Anonymous Types).
        // String [] Arr = {"aPPLE", "BlUeBeRrY", "cHeRry"};
        // var upperLowerWords = Arr.Select(word => new { Upper = word.ToUpper(), Lower = word.ToLower() });
        // foreach (var word in upperLowerWords)
        // {
        //     Console.WriteLine($"{word.Upper}, {word.Lower}");
        // }
        
        // // 3. Produce a sequence containing some properties of Products, including
        // // UnitPrice which is renamed to Price in the resulting type
        // var productInfo = ProductList.Select(product => new { product.ProductName, product.Category, Price = product.UnitPrice });
        // foreach (var product in productInfo)
        // {
        //     Console.WriteLine(product);
        // }

        #endregion
    }
}