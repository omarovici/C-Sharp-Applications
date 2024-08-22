using Microsoft.EntityFrameworkCore;

namespace Assignment_03_EF_Core.Contexts;

public class DemoDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=Northwind;User Id=SA;Password=MyStrongPass123;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .HasMany(x => x.ChildCategories)
            .WithOne(x => x.ParentCategory)
            .HasForeignKey(x => x.ParentCategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        // modelBuilder.Entity<Car>().HasBaseType<Vehicle>();
        // modelBuilder.Entity<Truck>().HasBaseType<Vehicle>();
        modelBuilder.Entity<Vehicle>()
            .HasDiscriminator<string>("VehicleType")
            .HasValue<Car>("Car")
            .HasValue<Truck>("Truck");

    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Truck> Trucks { get; set; }
}
// With Vehicle => Table per hierarchy
// Without Vehicle => Table per type 