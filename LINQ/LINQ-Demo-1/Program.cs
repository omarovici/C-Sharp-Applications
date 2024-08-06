namespace LINQ_Demo_1;
using static LINQ_Demo_1.ListGenerator;

class Program
{
    static void Main(string[] args)
    {
        #region Extension Method

        // string X = "Ahmed";
        // string Y = "1234";
        //
        // Console.WriteLine(X.IsNumeric());
        // bool flag = StringExtentionMethod.IsNumeric(Y);
        // Console.WriteLine(flag);

        #endregion

        #region What is Linq

        // // LINQ = Language Integrated Query
        // // Unified Syntax, Type Safety
        // // +40 Extension Methods => Interface: IEnumerable
        // // Linq Operators => 13 Categories
        // // It works against any Data (Stored in Sequence), Regardless Database Provider (SQL, PostgreSQL, MySql)
        // List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //
        // List<int> oddNumbers = numbers.Where(x => x % 2 == 1).ToList();
        //
        // foreach (var item in oddNumbers)
        // {
        //     Console.WriteLine(item);
        // }
        
        #endregion

        #region Linq Syntax
        // List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        #region 1.Fluent Syntax (Method Syntax)

        // // 1. Call "Linq Operator" as Static method through "Enumerable" Class
        // var oddNumbers = Enumerable.Where(numbers, x => x % 2 == 1);
        // foreach (var item in oddNumbers)
        // {
        //     Console.WriteLine(item);
        // }
        //
        // // 2. Call "Linq Operator" as Extension method
        // var evenNumbers = numbers.Where(x => x % 2 == 0);
        // foreach (var item in evenNumbers)
        // {
        //     Console.WriteLine(item);
        // }

        #endregion

        #region 2.Query Syntax
        
        // // Query Extention => Like SQL Query
        // // Start with "from"
        // // introduce range variable (x) => represent each element in the sequence
        // // Ens with "select" or "group by"
        //
        // // select Name
        // // from Students
        // // where Id = 10
        //
        // var oddNumbers =  from X in numbers
        //                   where X % 2 == 1
        //                   select X;
        //
        // foreach (var item in oddNumbers)
        // {
        //     Console.WriteLine(item);
        // }

        #endregion
        

        #endregion

        #region Linq Execution Ways

        #region Differed Execution

        // List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //
        // var oddNumbers = numbers.Where(x => x % 2 == 1);
        //
        // numbers.AddRange([ 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 ]);
        //
        // foreach (var item in oddNumbers)
        // {
        //     Console.WriteLine(item);
        // }

        #endregion

        #region Immediate Execution
        
        // // Element Operators, Casting Operators, Aggregate Operators
        // List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //
        // var oddNumbers = numbers.Where(x => x % 2 == 1).ToList();
        //
        // numbers.AddRange([ 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 ]);
        //
        // foreach (var item in oddNumbers)
        // {
        //     Console.WriteLine(item);
        // }

        #endregion
        
        #endregion

        #region Filteration (Restrictions) Operators [Where - OfType]

        // var outOfStockProducts = ProductList.Where(product => product.UnitsInStock == 0 && product.Category == "Meat/Poultry");
        //
        // outOfStockProducts = from Product in ProductList
        //     where Product.UnitsInStock == 0 && Product.Category == "Meat/Poultry"
        //         select Product;
        //
        // foreach (var product in outOfStockProducts)
        // {
        //     Console.WriteLine(product);
        // }

        // Indexed Where
        // Valid only with Fluent Syntax Cannot write it with query syntax
        // var result = ProductList.Where((product, index) => index < 20 && product.UnitsInStock == 0);
        // foreach (var product in result)
        // {
        //     Console.WriteLine(product);
        // }

        // ArrayList mixedList = new ArrayList() { 1, 2, "Ahmed", "Ali", 4, 7 };
        // List<string> names = mixedList.OfType<string>().ToList();
        //
        // foreach (var item in names)
        // {
        //     Console.WriteLine(item);
        // }

        #endregion

        #region Transformation (Projecting) Operators [Select - SelectMany]

        // var productsNames = ProductList.Select(product => product.ProductName);
        //
        // productsNames = from product in ProductList 
        //     select product.ProductName;
        //
        // var productsNamesOutOfStock = ProductList.Where(product=>product.UnitsInStock==0).Select(product => product.ProductName);
        //
        // foreach (var productName in productsNamesOutOfStock)
        // {
        //     Console.WriteLine(productName);
        // }
        
        // Indexed Select
        // Valid only with Fluent Syntax Cannot write it with query syntax
        // var productsNames = ProductList.Where(product => product.UnitsInStock == 0)
        //     .Select((product, index) => $"{index} : {product.ProductName}");
        //
        // foreach (var productName in productsNames)
        // {
        //     Console.WriteLine(productName);
        // }
        
        // Multiple Select
        // var products = ProductList
        //     .Where(product => product.UnitsInStock > 0)
        //     .Select(product => new ProductDto
        // {
        //     Id = product.ProductID,
        //     Name = product.ProductName,
        //     Price = product.UnitPrice
        // });
        //
        // products = from product in ProductList
        //     where product.UnitsInStock > 0
        //     select new ProductDto
        //     {
        //         Id = product.ProductID,
        //         Name = product.ProductName,
        //         Price = product.UnitPrice
        //     };
        //
        // foreach (var product in products)
        // {
        //     Console.WriteLine(product);
        // }

        // var customers = CustomerList.SelectMany(customer => customer.Orders);
        // // var customers = CustomerList.SelectMany((customer, index) => customer.Orders);
        // // var customer = CustomerList.SelectMany(customer => customer.Orders, (customer, order) => new { customer, order });
        // customers = from customer in CustomerList
        //     from order in customer.Orders
        //     select order;
        //         
        // // var customers = CustomerList.SelectMany(customer => customer.Orders , ((customer, order) => new {Name = customer.CustomerName, Order = order.OrderID}));
        //
        // foreach (var item in customers)
        // {
        //     Console.WriteLine(item);
        // }
        
        // var students = new []
        // {
        //     new {Name = "Ahmed", Grades = new [] {1, 2, 3, 4, 5}},
        //     new {Name = "Ali", Grades = new [] {6, 7, 8, 9, 10}},
        //     new {Name = "Omar", Grades = new [] {11, 12, 13, 14, 15}},
        // };
        //
        // var studentGrades = students.SelectMany(students => students.Grades,(students, grade) => new {Name = students.Name, Grade = grade});
        //
        // foreach (var item in studentGrades)
        // {
        //     Console.WriteLine(item);
        // }

        #endregion

        #region Overrinding Operators

        // var orderdProducts = ProductList.OrderBy(product => product.UnitPrice).ThenByDescending(product => product.UnitsInStock);
        //
        // orderdProducts = from product in ProductList
        //     orderby product.UnitPrice, product.UnitsInStock descending
        //     select product;
        //
        // foreach (var product in orderdProducts)
        // {
        //     Console.WriteLine(product);
        // }

        #endregion

        #region Element Operators - Immediate Operators
        // Valid Only with Fluent Syntax
        // List<Product> products = new List<Product>();
        
        // var result = ProductList.First(product => product.UnitsInStock == 1000);
        // var result = ProductList.First();
        // var result = products.First();
        // var result = products.FirstOrDefault(new Product{ProductID = 100 , ProductName = "Meat"});
        // var result = ProductList.FirstOrDefault(product => product.UnitsInStock == 0);
        
        // var result = ProductList.Last(product => product.UnitsInStock == 1000);
        // var result = ProductList.Last();
        // var result = products.Last();
        // var result = products.LastOrDefault(new Product{ProductID = 100 , ProductName = "Meat"});
        // var result = ProductList.LastOrDefault(product => product.UnitsInStock == 0);

        // var result = ProductList.ElementAt(5);
        // var result = products.ElementAtOrDefault(5);
        // var result = ProductList.ElementAtOrDefault(5000);
        // Console.WriteLine(result?.ProductName ?? "Not Found");
        // // 5 from the first
        // var result = ProductList.ElementAtOrDefault(new Index(5));
        // Console.WriteLine(result);
        // // 5 from the last
        // var result = ProductList.ElementAtOrDefault(new Index(5,true));
        // Console.WriteLine(result);

        // var result = ProductList.Single();
        // var result = products.Single();
        // Will work only if a sequence has only one element
        // Will throw an exception if a sequence has more than one element
        // var result = ProductList.SingleOrDefault();
        // var result = products.SingleOrDefault();
        // Will work only if a sequence has only one element or empty
        // Will throw an exception if a sequence has more than one element
        // var result = ProductList.SingleOrDefault(new Product{ProductID = 100 , ProductName = "Meat"});
        // var result = ProductList.Single(product => product.UnitsInStock == 0);
        // Will work only if a sequence has only one element that matches the condition
        // Will throw an exception if a sequence has more than one element that matches the condition
        // var result = ProductList.SingleOrDefault(product => product.UnitsInStock == 0);
        // Will work only if a sequence has only one element that matches the condition or zero condition
        // Will throw an exception if a sequence has more than one element that matches the condition

        // Mixed Syntax : (Query Syntax).FluentSyntax
        
        // var result = (from product in ProductList
        //     where product.UnitsInStock == 0
        //     select product).First();
        
        // var result = (from product in ProductList
        //     select product).Where(product => product.UnitsInStock == 0).First();
        
        // Console.WriteLine(result);

        #endregion

        #region Aggregate Operators - Immediate Execution

        // var count = ProductList.Count();
        // Console.WriteLine(count);
        
        // var count = ProductList.Count(product => product.UnitsInStock == 0);
        // Console.WriteLine(count);
        
        // var count = ProductList.Where(product => product.UnitsInStock == 0).Count();
        // Console.WriteLine(count);
        
        // var result = ProductList.Max(product => product.UnitPrice);
        // var result = ProductList.OrderByDescending(product => product.UnitPrice).FirstOrDefault();
        // var result = ProductList.MaxBy(product => product.UnitPrice);
        // var result = ProductList.Max();

        // var result = ProductList.Min(product => product.UnitPrice);
        // var result = ProductList.OrderBy(product => product.UnitPrice).FirstOrDefault();
        // var result = ProductList.MinBy(product => product.UnitPrice);
        
        // var result = ProductList.Sum(product => product.UnitPrice);
        
        // List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // List<string> categories = ProductList.Select(product=> product.Category).Distinct().ToList();
        // var result = numbers.Aggregate((x,y)=>x*y);
        // var result = categories.Aggregate((x,y)=> $"{x} / {y}" , categories => categories.Replace("B" , "$"));
        // Console.WriteLine(result);
        
        #endregion

        #region Casting Operators - Immediate Execution

        // List<Product> result = ProductList.Where(product => product.UnitsInStock == 0).ToList();
        // Product[] result = ProductList.Where(product => product.UnitsInStock == 0).ToArray();
        // Dictionary<long,Product> result = ProductList.Where(product => product.UnitsInStock == 0).ToDictionary(product => product.ProductID);
        // Dictionary<long,string> result = ProductList.Where(product => product.UnitsInStock == 0).ToDictionary(product => product.ProductID, product => product.ProductName);
        // foreach (var item in result)
        // {
        //     Console.WriteLine(item);
        // }
        #endregion

        #region Generation Operators

        // var result = Enumerable.Range(0, 100);
        // foreach (var item in result)
        // {
        //     Console.WriteLine(item);
        // }
        // var result = Enumerable.Repeat(ProductList[3],10);
        // foreach (var item in result)
        // {
        //     Console.WriteLine(item);
        // }
        // var result = Enumerable.Empty<int>().ToList(); // IEnumerable<int> numbers = new List<int>();
        // foreach (var item in result)
        // {
        //     Console.WriteLine(item);
        // }

        #endregion

        #region Set Operators - Union Family

        // var seq01 = Enumerable.Range(0, 100);
        // var seq02 = Enumerable.Range(50, 100);
        // var result = seq01.Union(seq02);
        // var result = seq01.Except(seq02);
        // var result = seq01.Concat(seq02);
        // foreach (var item in seq02)
        // {
        //     Console.Write($"{item} , ");
        // }

        // var seq01 = new List<Product>()
        // {
        //     ProductList[0],
        //     ProductList[1],
        //     ProductList[2],
        //     ProductList[3]
        // };
        // var seq02 = new List<Product>()
        // {
        //     ProductList[0],
        //     ProductList[1],
        //     ProductList[2],
        //     ProductList[5]
        // };
        
        // var result = seq01.Union(seq02);
        // var result = seq01.Concat(seq02);
        // var result = seq01.Union(seq02,new ProductEqualityComparer());
        // var result = seq01.UnionBy(seq02, product => product.ProductID);
        // foreach (var item in result)
        // {
        //     Console.WriteLine(item);
        // }


        #endregion

    }
}