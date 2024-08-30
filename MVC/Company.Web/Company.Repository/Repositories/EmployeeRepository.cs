using Company.Repository.Interfaces;
using Data.Models.Contexts;
using Data.Models.Entities;

namespace Company.Repository.Repositories;

public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
{
    private readonly CompanyDbContext _context;
    public EmployeeRepository(CompanyDbContext context) : base(context)
    {
    }

    public Employee GetEmployeeByName(string name)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Employee> GetEmployeesByAddress(string address)
    {
        throw new NotImplementedException();
    }
}