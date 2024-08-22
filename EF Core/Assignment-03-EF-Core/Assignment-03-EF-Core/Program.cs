using Assignment_03_EF_Core.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Assignment_03_EF_Core;

class Program
{
    static void Main(string[] args)
    {
        using (DemoDbContext context = new DemoDbContext())
        {
            try
            {
                // var parentCategory = new Category
                // {
                //     Name = "Electronics",
                //     Description = "This is the parent category"
                // };
                // var childCategory = new Category
                // {
                //     Name = "Laptops",
                //     Description = "This is the child category",
                //     ParentCategory = parentCategory
                // };
                // context.Categories.Add(parentCategory);
                // context.Categories.Add(childCategory);
                // context.SaveChanges();

                // Car car01 = new Car()
                // {
                //     Name = "BMW",
                //     Model = "X5",
                //     NumberOfDoors = 4
                // };
                // Car car02 = new Car()
                // {
                //     Name = "Mercedes",
                //     Model = "AMG",
                //     NumberOfDoors = 4
                // };
                // Truck truck01 = new Truck()
                // {
                //     Name = "Fiat",
                //     Model = "Uno",
                //     LoadCapacity = 500
                // };
                // Truck truck02 = new Truck()
                // {
                //     Name = "Mitsubishi",
                //     Model = "Lancer",
                //     LoadCapacity = 700
                // };
                // context.Vehicles.Add(car01);
                // context.Add(car02);
                // context.Vehicles.Add(truck01);
                // context.Set<Truck>().Add(truck02);
                // context.SaveChanges();
                
                // var cars = context.Vehicles.Where(x => EF.Property<string>(x,"VehicleType") == "Car").ToList();
                // foreach (var car in context.Vehicles.OfType<Car>())
                // {
                //     Console.WriteLine(car);
                // }
                // foreach (var car in context.Cars)
                // {
                //     Console.WriteLine(car);
                // }

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
        }
    }
}