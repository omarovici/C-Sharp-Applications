using Data.Models.Entities;

namespace Company.Service.Interfaces;

public interface IdepartmentService
{
    Department GetById(int? id);
    
    IEnumerable<Department> GetAll();
    
    void Add(Department department);
    
    void Update(Department department);
    
    void Delete(Department department);

}