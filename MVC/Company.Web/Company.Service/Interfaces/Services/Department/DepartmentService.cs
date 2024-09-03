using Company.Repository.Interfaces;
using Data.Models.Entities;

namespace Company.Service.Interfaces.Services;

public class DepartmentService : IdepartmentService
{
    private readonly IUnitOfWork _unitOfWork;
    public DepartmentService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Department GetById(int? id)
    {
        if (id is null)
            return null;
        
        var department = _unitOfWork.DepartmentRepository.GetById(id.Value);
        if (department is null)
            return null;
        
        return department;
    }

    public IEnumerable<Department> GetAll()
    {
        var departments = _unitOfWork.DepartmentRepository.GetAll();
        return departments;
    }

    public void Add(Department department)
    {
        var mappedDepartment = new Department()
        {
            Code = department.Code,
            Name = department.Name,
            CreateAt = DateTime.Now,
        };
        
        _unitOfWork.DepartmentRepository.Add(mappedDepartment);

        _unitOfWork.Complete();
    }

    public void Update(Department department)
    {
        _unitOfWork.DepartmentRepository.Update(department);

        _unitOfWork.Complete();
    }

    public void Delete(Department department)
    {
        _unitOfWork.DepartmentRepository.Delete(department);

        _unitOfWork.Complete();
    }
}