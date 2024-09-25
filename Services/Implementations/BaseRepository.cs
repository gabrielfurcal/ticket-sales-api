using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Services.Implementations
{
    public class BaseRepository<T, K> : IBaseRepository<T, K> where T : class
    {
        private readonly IDbContextFactory<TicketSaleDbContext> _contextFactory;

        public BaseRepository(IDbContextFactory<TicketSaleDbContext> contextFactory)
        {
            this._contextFactory = contextFactory;
        }

        public async Task<List<T>> FindAll()
        {
            try 
            {
                using(TicketSaleDbContext _context = _contextFactory.CreateDbContext())
                {
                    var entities = _context.Set<T>().ToListAsync();
                    return await entities;
                }
            } catch (Exception ex) 
            {
                Console.Write($"Error finding List of {nameof(T)}. Message: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<T>> FindAll(Expression<Func<T, object>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> FindAll(Expression<Func<T, object>>[] predicates)
        {
            throw new NotImplementedException();
        }

        public async Task<T> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> FindFilteringList(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Save(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteById(K id)
        {
            throw new NotImplementedException();
        }
    }
}