using AutoMapper;
using Company.Service.Interfaces.Dto;
using Data.Models.Entities;

namespace Company.Service.Mapping;

public class DepartmentProfile : Profile
{
    public DepartmentProfile()
    {
        CreateMap<Department, DepartmentDto>().ReverseMap();
    }
}