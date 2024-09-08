using System.Reflection;
using Data.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data.Models.Contexts;

public class CompanyDbContext : IdentityDbContext<ApplicationUser>
{ 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        // modelBuilder.Entity<BaseEntity>().HasQueryFilter(x => !x.IsDeleted);
        base.OnModelCreating(modelBuilder);
    }
    
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
}