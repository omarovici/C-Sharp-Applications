using Company.Repository.Interfaces;
using Data.Models.Contexts;
using Data.Models.Entities;

namespace Company.Repository.Repositories;

public class DepartmentRepository : GenericRepository <Department>, IDepartmentRepository
{
    private readonly CompanyDbContext _context;
    public DepartmentRepository(CompanyDbContext context) : base(context)
    {
    }
}