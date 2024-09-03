using Company.Repository.Interfaces;
using Data.Models.Contexts;

namespace Company.Repository.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly CompanyDbContext _context;
    public UnitOfWork(CompanyDbContext context)
    {
        _context = context;
        DepartmentRepository = new DepartmentRepository(context);
        EmployeeRepository = new EmployeeRepository(context);
    }
    public IDepartmentRepository DepartmentRepository { get; set; }
    public IEmployeeRepository EmployeeRepository { get; set; }
    public int Complete() => _context.SaveChanges();
}