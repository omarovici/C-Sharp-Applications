using Data.Models.Entities;

namespace Company.Repository.Interfaces;

public interface IGenericRepository<T> where T : BaseEntity
{
    T GetById(int id);
    
    IEnumerable<T> GetAll();
    
    void Add(T entity);
    
    void Update(T entity);
    
    void Delete(T entity);

}