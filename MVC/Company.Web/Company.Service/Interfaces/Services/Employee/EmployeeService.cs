using Company.Repository.Interfaces;
using Data.Models.Entities;

namespace Company.Service.Interfaces.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IUnitOfWork _unitOfWork;

    public EmployeeService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public Employee GetById(int? id)
    {
        if (id is null)
            return null;
        
        var employee = _unitOfWork.EmployeeRepository.GetById(id.Value);
        if (employee is null)
            return null;
        
        return employee;
    }

    public IEnumerable<Employee> GetAll()
    {
        var employees = _unitOfWork.EmployeeRepository.GetAll();
        return employees;
    }

    public void Add(Employee department)
    {
        var mappedDepartment = new Employee()
        {
            Id = department.Id,
            Name = department.Name,
        };

        _unitOfWork.EmployeeRepository.Add(mappedDepartment);
        _unitOfWork.Complete();

    }

    public void Update(Data.Models.Entities.Employee department)
    {
        _unitOfWork.EmployeeRepository.Update(department);
        _unitOfWork.Complete();
    }

    public void Delete(Data.Models.Entities.Employee department)
    {
        _unitOfWork.EmployeeRepository.Delete(department);
        _unitOfWork.Complete();
    }
}