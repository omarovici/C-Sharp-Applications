using Company.Repository.Interfaces;
using Data.Models.Contexts;
using Data.Models.Entities;

namespace Company.Repository.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    private readonly CompanyDbContext _context;

    public GenericRepository(CompanyDbContext context)
    {
        _context = context;
    }
    public T GetById(int id) => _context.Set<T>().FirstOrDefault(x => x.Id == id);

    public IEnumerable<T> GetAll() => _context.Set<T>().ToList();

    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);

        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);

        _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);

        _context.SaveChanges();
    }
}