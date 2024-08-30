using Data.Models.Entities;

namespace Company.Repository.Interfaces;

public interface IEmployeeRepository : IGenericRepository<Employee>
{
    Employee GetEmployeeByName(string name);
    IEnumerable<Employee> GetEmployeesByAddress(string address);
}