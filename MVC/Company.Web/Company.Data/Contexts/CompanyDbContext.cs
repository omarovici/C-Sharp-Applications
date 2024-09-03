using System.Reflection;
using Data.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Models.Contexts;

public class CompanyDbContext : DbContext
{
    public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options)
    {
    }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlServer("Server=localhost,1433;Database=ITI;User Id=SA;Password=MyStrongPass123;TrustServerCertificate=True;");
    // }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        // modelBuilder.Entity<BaseEntity>().HasQueryFilter(x => !x.IsDeleted);
        base.OnModelCreating(modelBuilder);
    }
    
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
}