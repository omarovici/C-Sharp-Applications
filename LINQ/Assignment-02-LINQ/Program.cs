namespace Assignment_02_LINQ;
using static Assignment_02_LINQ.ListGenerator;
class Program
{
    static void Main(string[] args)
    {
        #region LINQ - Element Operators

        // // 1. Get the first Product out of Stock
        // var firstProductOutOfStock = ProductList.First(product => product.UnitsInStock == 0);
        // Console.WriteLine(firstProductOutOfStock);
        
        // // 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
        // var firstProductPrice1000 = ProductList.FirstOrDefault(product => product.UnitPrice > 1000);
        // Console.WriteLine(firstProductPrice1000);
        
        // // 3. Retrieve the second number greater than 5 
        // int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
        // var secondNumberGreaterThanFive = Arr.Where(number => number > 5).Skip(1).First();
        // Console.WriteLine(secondNumberGreaterThanFive);
        #endregion

        #region LINQ - Aggregate Operators

        // // 1. Uses Count to get the number of odd numbers in the array
        // int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
        // var countOddNumbers = Arr.Count(num => num % 2 == 1);
        // Console.WriteLine(countOddNumbers);
        
        // // 2. Return a list of customers and how many orders each has.
        // var listOfCountomersCountOrders = CustomerList.Select(customer =>
        //     new { customerName = customer.CustomerName, totalorders = customer.Orders.Count() }).ToList();
        // foreach (var customer in listOfCountomersCountOrders)
        // {
        //     Console.WriteLine($"Customer Name : {customer.customerName} , Count of orders : {customer.totalorders}");
        // }
        
        // // 3. Return a list of categories and how many products each has the name of the category then the count of products
        // var listOfCategoriesCountProducts = ProductList.GroupBy(product => product.Category)
        //     .Select(category => new { categoryName = category.Key, countProducts = category.Count() })
        //     .ToList();
        //
        // foreach (var category in listOfCategoriesCountProducts)
        // {
        //     Console.WriteLine($"Category Name : {category.categoryName}, Count of products : {category.countProducts}");
        // }
        
        // // 4. Get the total of the numbers in an array.
        // int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
        // var totalNumbers = Arr.Aggregate((x,y) => x+y);
        // Console.WriteLine(totalNumbers);
        
        // // 5. Get the total number of characters of all words in dictionary_english.txt (Read
        // // dictionary_english.txt into Array of String First).
        // string[] englishDictionary = File.ReadAllLines("dictionary_english.txt");
        // var totalNumbersChar = englishDictionary.Sum(word => word.Length);
        // Console.WriteLine(totalNumbersChar);
        
        // // 6. Get the length of the shortest word in dictionary_english.txt (Read
        // // dictionary_english.txt into Array of String First).
        // var shortestWord = englishDictionary.Min(word => word.Length);
        // Console.WriteLine(shortestWord);
        
        // // 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
        // var longestWord = englishDictionary.Max(word => word.Length);
        // Console.WriteLine(longestWord);
             
        // // 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
        // var averageWord = englishDictionary.Average(word => word.Length);
        // Console.WriteLine(averageWord);
        
        // // 9. Get the total units in stock for each product category.
        // var totalUnitsInStock = ProductList.GroupBy(product => product.Category)
        //     .Select(category => new { categoryName = category.Key, totalUnits = category.Sum(product => product.UnitsInStock) })
        //     .ToList();
        // foreach (var category in totalUnitsInStock)
        // {
        //     Console.WriteLine($"Category Name : {category.categoryName}, Total Units : {category.totalUnits}");
        // }
        
        #endregion

        #region LINQ - Set Operators

        // // 1. Find the unique Category names from Product List
        // var uniqueCategories = ProductList.Select(product => product.Category).Distinct();
        // foreach (var category in uniqueCategories)
        // {
        //     Console.WriteLine(category);
        // }
        
        // // 2. Produce a Sequence containing the unique first letter from both product and
        // // customer names.
        // var uniqueFirstLetters = ProductList.Select(product => product.ProductName[0])
        //     .Concat(CustomerList.Select(customer => customer.CustomerName[0]))
        //     .Distinct();
        // foreach (var letter in uniqueFirstLetters)
        // {
        //     Console.Write($"{letter} , ");
        // }
        
        // // 3. Create one sequence that contains the common first letter from both product
        // // and customer names.
        // var commonFirstLetters = ProductList.Select(product => product.ProductName[0])
        //     .Intersect(CustomerList.Select(customer => customer.CustomerName[0]));
        // foreach (var letter in commonFirstLetters)
        // {
        //     Console.Write($"{letter} , ");
        // }
        
        // // 4. Create one sequence that contains the first letters of product names that are
        // // not also first letters of customer names.
        // var notCommonFirstLetters = ProductList.Select(product => product.ProductName[0])
        //     .Except(CustomerList.Select(customer => customer.CustomerName[0]));
        // foreach (var letter in notCommonFirstLetters)
        // {
        //     Console.Write($"{letter} , ");
        // }
        
        // // 5. Create one sequence that contains the last Three Characters in each name of
        // // all customers and products, including any duplicates
        // var lastThreeLetters = CustomerList.Select(customer => customer.CustomerName.Substring(customer.CustomerName.Length - 3))
        //     .Concat(ProductList.Select(product => product.ProductName.Substring(product.ProductName.Length - 3)))
        //     .Distinct();
        // foreach (var letter in lastThreeLetters)
        // {
        //     Console.Write($"{letter} , ");
        // }
        #endregion

        #region LINQ - Quantifiers

        // // 1. Determine if any of the words in dictionary_english.txt (Read
        // // dictionary_english.txt into Array of String First) contain the substring 'ei
        // string[] englishDictionary = File.ReadAllLines("dictionary_english.txt");
        // var containsEi = englishDictionary.Any(word => word.Contains("ei"));
        // Console.WriteLine(containsEi);

        // // 2. Return a grouped a list of products only for categories that have at least
        // // one product that is out of stock.
        // var outOfStockProducts = ProductList.GroupBy(product => product.Category)
        //     .Where(category => category.Any(product => product.UnitsInStock == 0))
        //     .ToList();
        // foreach (var category in outOfStockProducts)
        // {
        //     Console.WriteLine($"Category Name : {category.Key}");
        //     Console.Write("Products : ");
        //     foreach (var product in category)
        //     {
        //         Console.Write($"{product.ProductName} , ");
        //     }
        //     Console.WriteLine();
        // }
        
        // // 3. Return a grouped a list of products only for categories that have all of their
        // // products in stock.
        // var inStockProducts = ProductList.GroupBy(product => product.Category)
        //     .Where(category => category.All(product => product.UnitsInStock > 0))
        //     .ToList();
        // foreach (var category in inStockProducts)
        // {
        //     Console.WriteLine($"Category Name : {category.Key}");
        //     Console.Write("Products : ");
        //     foreach (var product in category)
        //     {
        //         Console.Write($"{product.ProductName} , ");
        //     }
        //     Console.WriteLine();
        // }
        #endregion

        #region LINQ – Grouping Operators

        // // 1. Use group by to partition a list of numbers by their remainder when divided by 5 
        
        // List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        // for (int i = 0; i < 5; i++)
        // {
        //     var numbersByRemainder = numbers.GroupBy(number => number % 5 == i);
        //     Console.WriteLine($"Numbers with a remainder of {i} when divided by 5:");
        //     foreach (var group in numbersByRemainder)
        //     {
        //         if (group.Key) Console.WriteLine(string.Join("\n", group));
        //     }
        // }


        #endregion
    }
}