using Data.Models.Entities;

namespace Company.Service.Interfaces;

public interface IEmployeeService
{
    Employee GetById(int? id);
    
    IEnumerable<Employee> GetAll();
    
    void Add(Employee department);
    
    void Update(Employee department);
    
    void Delete(Employee department);

}