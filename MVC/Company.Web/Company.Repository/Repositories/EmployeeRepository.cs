using Company.Repository.Interfaces;
using Data.Models.Contexts;
using Data.Models.Entities;

namespace Company.Repository.Repositories;

public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
{
    private readonly CompanyDbContext _context;
    public EmployeeRepository(CompanyDbContext context) : base(context)
    {
        _context = context;
    }

    public IEnumerable<Employee> GetEmployeeByName(string name)
        => _context.Employees.Where(x => x.Name.Trim().ToLower().Contains(name.Trim().ToLower()) 
            || x.Email.Trim().ToLower().Contains(name.Trim().ToLower())
            || x.PhoneNumber.Trim().ToLower().Contains(name.Trim().ToLower())
            ).ToList();

    public IEnumerable<Employee> GetEmployeesByAddress(string address)
    {
        throw new NotImplementedException();
    }
}