using AutoMapper;
using Company.Repository.Interfaces;
using Company.Service.Interfaces.Dto;
using Data.Models.Entities;

namespace Company.Service.Interfaces.Services;

public class DepartmentService : IdepartmentService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    
    public DepartmentService(IUnitOfWork unitOfWork,IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public DepartmentDto GetById(int? id)
    {
        if (id is null)
            return null;
        
        var department = _unitOfWork.DepartmentRepository.GetById(id.Value);
        if (department is null)
            return null;
        
        var mappedDepartment = _mapper.Map<DepartmentDto>(department);
        return mappedDepartment;
    }

    public IEnumerable<DepartmentDto> GetAll()
    {
        var departments = _unitOfWork.DepartmentRepository.GetAll();
        var mappedDepartments = _mapper.Map<IEnumerable<DepartmentDto>>(departments);
        return mappedDepartments;
    }

    public void Add(DepartmentDto departmentDto)
    {
        // var mappedDepartment = new DepartmentDto()
        // {
        //     Code = department.Code,
        //     Name = department.Name,
        //     CreateAt = DateTime.Now,
        // };
        
        var mappedDepartment = _mapper.Map<Department>(departmentDto);
        
        _unitOfWork.DepartmentRepository.Add(mappedDepartment);

        _unitOfWork.Complete();
    }

    public void Update(DepartmentDto department)
    {
        // _unitOfWork.DepartmentRepository.Update(department);
        // _unitOfWork.Complete();

        // var mappedDepartment = _mapper.Map<Department>(department);
        // _unitOfWork.DepartmentRepository.Update(mappedDepartment);
        // _unitOfWork.Complete();
    }

    public void Delete(DepartmentDto departmentDto)
    {
        var mappedDepartment = _mapper.Map<Department>(departmentDto);
        _unitOfWork.DepartmentRepository.Delete(mappedDepartment);

        _unitOfWork.Complete();
    }
}