using Assignment_02_EF_Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment_02_EF_Core.Contexts;

public class ITIDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=ITI;User Id=SA;Password=MyStrongPass123;TrustServerCertificate=True;");
    }

    public DbSet<Department> Department { get; set; }
    public DbSet<Instructor> Instructor { get; set; }
    public DbSet<Student> Student { get; set; }
    public DbSet<Course> Course { get; set; }
    public DbSet<Stud_Course> Stud_Course { get; set; }
    public DbSet<Course_Inst> Course_Inst { get; set; }
    public DbSet<Topic> Topic { get; set; }
}