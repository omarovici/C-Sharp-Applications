using DatabaseFirst.Context;
using DatabaseFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst;

class Program
{
    static void Main(string[] args)
    {
        #region Run Sql Query

        using (MyDbContext context = new MyDbContext())
        {
            // 1. Execute Select Statement
            // var result = context.Categories.FromSqlRaw("SELECT * FROM Categories").ToList();
            // var category = "Beverages";
            // var result = context.Categories.FromSqlInterpolated($"SELECT * FROM Categories where CategoryName = {category}").ToList();
            // var result = context.Categories.Where(x => x.CategoryName == "Beverages").ToList();
            // foreach (var item in result)
            // {
            //     Console.WriteLine($"{item.CategoryName} :: {item.Description}");
            // }
            
            // 2. Execute DML Query
            // context.Database.ExecuteSqlInterpolated($"UPDATE PRODUCTS SET PRODUCTNAME = 'ZABADI' WHERE PRODUCTID = 1");

            // Lazy loading 
            // var product = context.Products.FirstOrDefault();
            // var categoryName = product.Category.CategoryName;
            // Console.WriteLine(categoryName);
            
            // context.Entry(product).Reference(x => x.Category).Load();
            // var categoryName = product.Category.CategoryName;
            
            // context.Products.Load();
            //
            // if(context.Products.Any(x => x.UnitsInStock == 0))
            //     Console.WriteLine("There are products with 0 units in stock");
            // else 
            //     Console.WriteLine("There are no products with 0 units in stock");

        }

        #endregion
    }
}