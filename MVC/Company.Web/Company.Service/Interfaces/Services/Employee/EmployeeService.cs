using AutoMapper;
using Company.Repository.Interfaces;
using Company.Service.Helper;
using Company.Service.Interfaces.Dto;
using Data.Models.Entities;

namespace Company.Service.Interfaces.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public EmployeeService(IUnitOfWork unitOfWork,IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public EmployeeDto GetById(int? id)
    {
        if (id is null)
            return null;
        
        var employee = _unitOfWork.EmployeeRepository.GetById(id.Value);
        if (employee is null)
            return null;
        // EmployeeDto employeeDto = new EmployeeDto()
        // {
        //     Address = employee.Address,
        //     Age = employee.Age,
        //     DepartmentId = employee.DepartmentId,
        //     Email = employee.Email,
        //     HireDate = employee.HireDate,
        //     ImageUrl = employee.ImageUrl,
        //     Name = employee.Name,
        //     PhoneNumber = employee.PhoneNumber,
        //     Salary = employee.Salary,
        //     Id = employee.Id,
        //     CreateAt = employee.CreateAt
        // };
        
        

        EmployeeDto employeeDto = _mapper.Map<EmployeeDto>(employee);
        
        return employeeDto;
    }

    public IEnumerable<EmployeeDto> GetAll()
    {
        var employees = _unitOfWork.EmployeeRepository.GetAll();
        // var mappedEmployees = employees.Select(employee => new EmployeeDto(
        // {
        //     Address = employee.Address,
        //     Age = employee.Age,
        //     DepartmentId = employee.DepartmentId,
        //     Email = employee.Email,
        //     HireDate = employee.HireDate,
        //     ImageUrl = employee.ImageUrl,
        //     Name = employee.Name,
        //     PhoneNumber = employee.PhoneNumber,
        //     Salary = employee.Salary,
        //     Id = employee.Id,
        //     CreateAt = employee.CreateAt
        // });
        IEnumerable<EmployeeDto> mappedEmployees = _mapper.Map<IEnumerable<EmployeeDto>>(employees);
        return mappedEmployees;
    }

    public void Add(EmployeeDto employeeDto)
    {
        // Manual Mapping
        // Employee employee = new Employee()
        // {
        //     Address = employeeDto.Address,
        //     Age = employeeDto.Age,
        //     DepartmentId = employeeDto.DepartmentId,
        //     Email = employeeDto.Email,
        //     HireDate = employeeDto.HireDate,
        //     ImageUrl = employeeDto.ImageUrl,
        //     Name = employeeDto.Name,
        //     PhoneNumber = employeeDto.PhoneNumber,
        //     Salary = employeeDto.Salary,
        // };
        
        employeeDto.ImageUrl = DocumentSettings.UploadFile(employeeDto.Image, "Images");
        
        Employee employee = _mapper.Map<Employee>(employeeDto);

        _unitOfWork.EmployeeRepository.Add(employee);

        _unitOfWork.Complete();
    }

    public void Update(EmployeeDto employee)
    {
        // _unitOfWork.EmployeeRepository.Update(employee);
        _unitOfWork.Complete();
    }

    public void Delete(EmployeeDto employeeDto)
    {
        // Employee employee = new Employee()
        // {
        //     Address = employeeDto.Address,
        //     Age = employeeDto.Age,
        //     DepartmentId = employeeDto.DepartmentId,
        //     Email = employeeDto.Email,
        //     HireDate = employeeDto.HireDate,
        //     ImageUrl = employeeDto.ImageUrl,
        //     Name = employeeDto.Name,
        //     PhoneNumber = employeeDto.PhoneNumber,
        //     Salary = employeeDto.Salary,
        // };
        Employee employee = _mapper.Map<Employee>(employeeDto);
        _unitOfWork.EmployeeRepository.Delete(employee);

        _unitOfWork.Complete();
    }

    public IEnumerable<EmployeeDto> GetEmployeeByName(string name)
    {
        var employees = _unitOfWork.EmployeeRepository.GetEmployeeByName(name);
        // var mappedEmployees = employees.Select(employee => new EmployeeDto(
        // {
        //     Address = employee.Address,
        //     Age = employee.Age,
        //     DepartmentId = employee.DepartmentId,
        //     Email = employee.Email,
        //     HireDate = employee.HireDate,
        //     ImageUrl = employee.ImageUrl,
        //     Name = employee.Name,
        //     PhoneNumber = employee.PhoneNumber,
        //     Salary = employee.Salary,
        //     Id = employee.Id,
        //     CreateAt = employee.CreateAt
        // });
        IEnumerable<EmployeeDto> mappedEmployees = _mapper.Map<IEnumerable<EmployeeDto>>(employees);
        return mappedEmployees;
    }
}