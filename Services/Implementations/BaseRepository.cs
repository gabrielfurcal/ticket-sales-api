using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;
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
                    var entities = await _context.Set<T>().ToListAsync();
                    return entities;
                }
            } catch (Exception ex) 
            {
                Console.Write($"Error finding List of {nameof(T)}. Message: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<T>> FindAll(Expression<Func<T, object>> predicate)
        {
            try
            {
                using(TicketSaleDbContext _context = _contextFactory.CreateDbContext())
                {
                    var entities = _context.Set<T>().Include(predicate).ToListAsync();

                    return await entities;
                }
            }
            catch (Exception ex)
            {
                Console.Write($"Error finding List of {nameof(T)}. Message: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<T>> FindAll(Expression<Func<T, object>>[] predicates)
        {
            try
            {
                using(TicketSaleDbContext _context = _contextFactory.CreateDbContext())
                {
                    var entities = _context.Set<T>().AsQueryable();

                    foreach (var item in predicates)
                    {
                        entities = entities.Include(item);
                    }

                    return await entities.ToListAsync();
                }
            }
            catch (Exception ex)
            {
                Console.Write($"Error finding List of {nameof(T)}. Message: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<T>> FindFilteringList(Expression<Func<T, bool>> predicate)
        {
            try
            {
                using(TicketSaleDbContext _context = _contextFactory.CreateDbContext())
                {
                    var entities = await _context.Set<T>().Where(predicate).ToListAsync();

                    return entities;
                }
            }
            catch (Exception ex)
            {
                Console.Write($"Error finding List of {nameof(T)}. Message: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task<T?> FindById(K id)
        {
            try
            {
                using(TicketSaleDbContext _context = _contextFactory.CreateDbContext())
                {
                    var entity = await _context.Set<T>().FindAsync(id);
                    return entity;
                }
            }
            catch (Exception ex)
            {
                Console.Write($"Error finding element of {nameof(T)}, with ID: {id}. Message: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }


        public async Task<T> Save(T entity, K? id)
        {
            try
            {
                using(TicketSaleDbContext _context = _contextFactory.CreateDbContext())
                {
                    var dbEntity = await _context.Set<T>().FindAsync(id);

                    if (dbEntity != null)
                    {
                        _context.Entry(entity).State = EntityState.Modified;
                    }
                    else
                    {
                        await _context.Set<T>().AddAsync(entity);
                    }

                    await _context.SaveChangesAsync();

                    return entity;
                }
            }
            catch (Exception ex)
            {
                Console.Write($"Error saving entity of {nameof(T)}. Message: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteById(K id)
        {
            try
            {
                using(TicketSaleDbContext _context = _contextFactory.CreateDbContext())
                {
                    var entity = await _context.Set<T>().FindAsync(id);
                    
                    if (entity != null)
                    {
                        _context.Set<T>().Remove(entity);

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write($"Error deleting element of {nameof(T)}, with ID: {id}. Message: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }
    }
}