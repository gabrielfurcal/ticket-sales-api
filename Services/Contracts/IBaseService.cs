using System.Linq.Expressions;

namespace ticket_store_api.Services.Contracts
{
    public interface IBaseService<T, K, M>
    {
        Task<List<M>> FindAll();
        Task<List<M>> FindAll(Expression<Func<T, object>> predicate);
        Task<List<M>> FindAll(Expression<Func<T, object>>[] predicates);
        Task<List<M>> FindFilteringList(Expression<Func<T, bool>> predicate);
        Task<M> FindById(K id);
        Task<M> Save(M dto, K? id);
        Task<bool> DeleteById(K id);
    }
}