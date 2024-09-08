using AutoMapper;
using Company.Service.Interfaces.Dto;
using Data.Models.Entities;

namespace Company.Service.Mapping;

public class EmployeeProfile : Profile
{
    public EmployeeProfile()
    {
        CreateMap<Employee, EmployeeDto>().ReverseMap();
    }
}