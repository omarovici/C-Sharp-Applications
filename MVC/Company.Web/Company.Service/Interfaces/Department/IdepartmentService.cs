using Company.Service.Interfaces.Dto;
using Data.Models.Entities;

namespace Company.Service.Interfaces;

public interface IdepartmentService
{
    DepartmentDto GetById(int? id);
    
    IEnumerable<DepartmentDto> GetAll();
    
    void Add(DepartmentDto department);
    
    void Update(DepartmentDto department);
    
    void Delete(DepartmentDto department);

}