using System.Linq.Expressions;

namespace ticket_store_api.Services.Contracts
{
    public interface IBaseRepository<T, K>
    {
        Task<List<T>> FindAll();
        Task<List<T>> FindAll(Expression<Func<T, object>> predicate);
        Task<List<T>> FindAll(Expression<Func<T, object>>[] predicates);
        Task<List<T>> FindFilteringList(Expression<Func<T, bool>> predicate);
        Task<T> FindById(int id);
        Task<T> Save(T entity);
        Task<bool> DeleteById(K id);
    }
}