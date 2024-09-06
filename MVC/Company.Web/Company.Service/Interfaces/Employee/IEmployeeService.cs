using Company.Service.Interfaces.Dto;
using Data.Models.Entities;

namespace Company.Service.Interfaces;

public interface IEmployeeService
{
    EmployeeDto GetById(int? id);
    
    IEnumerable<EmployeeDto> GetAll();
    
    void Add(EmployeeDto employee);
    
    void Update(EmployeeDto employee);
    
    void Delete(EmployeeDto employee);

    IEnumerable<EmployeeDto> GetEmployeeByName(string name);

}