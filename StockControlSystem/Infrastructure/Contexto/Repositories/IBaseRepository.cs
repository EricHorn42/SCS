using StockControlSystem.Models;

namespace StockControlSystem.Infrastructure.Contexto.Repositories
{
    public interface IBaseRepository<T> where T : class, IEntity
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}