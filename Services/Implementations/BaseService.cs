using System.Linq.Expressions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Services.Implementations
{
    public class BaseService<T, K, M> : IBaseService<T, K, M> where T : class
    {
        private readonly IDbContextFactory<TicketSaleDbContext> _contextFactory;
        private readonly IMapper _mapper;

        public BaseService(IDbContextFactory<TicketSaleDbContext> contextFactory, IMapper mapper)
        {
            this._contextFactory = contextFactory;
            this._mapper = mapper;
        }

        public async Task<List<M>> FindAll()
        {
            try 
            {
                using(TicketSaleDbContext _context = _contextFactory.CreateDbContext())
                {
                    var entities = await _context.Set<T>().ToListAsync();
                    var listResponse = entities.Select(e => _mapper.Map<T, M>(e)).ToList();
                    return listResponse;
                }
            } catch (Exception ex) 
            {
                Console.Write($"Error finding List of {nameof(T)}. Message: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<M>> FindAll(Expression<Func<T, object>> predicate)
        {
            try
            {
                using(TicketSaleDbContext _context = _contextFactory.CreateDbContext())
                {
                    var entities = await _context.Set<T>().Include(predicate).ToListAsync();
                    var listResponse = entities.Select(e => _mapper.Map<T, M>(e)).ToList();

                    return listResponse;
                }
            }
            catch (Exception ex)
            {
                Console.Write($"Error finding List of {nameof(T)}. Message: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<M>> FindAll(Expression<Func<T, object>>[] predicates)
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

                    var entitiesList = await entities.ToListAsync();
                    var listResponse = entities.Select(e => _mapper.Map<T, M>(e)).ToList();

                    return listResponse;
                }
            }
            catch (Exception ex)
            {
                Console.Write($"Error finding List of {nameof(T)}. Message: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<M>> FindFilteringList(Expression<Func<T, bool>> predicate)
        {
            try
            {
                using(TicketSaleDbContext _context = _contextFactory.CreateDbContext())
                {
                    var entities = await _context.Set<T>().Where(predicate).ToListAsync();
                    var listResponse = entities.Select(e => _mapper.Map<T, M>(e)).ToList();

                    return listResponse;
                }
            }
            catch (Exception ex)
            {
                Console.Write($"Error finding List of {nameof(T)}. Message: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public async Task<M> FindById(K id)
        {
            try
            {
                using(TicketSaleDbContext _context = _contextFactory.CreateDbContext())
                {
                    var entity = await _context.Set<T>().FindAsync(id);

                    if (entity is null) throw new Exception($"{nameof(T)} not found");

                    return _mapper.Map<T, M>(entity);

                }
            }
            catch (Exception ex)
            {
                Console.Write($"Error finding element of {nameof(T)}, with ID: {id}. Message: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }


        public async Task<M> Save(M dto, K? id)
        {
            try
            {
                using(TicketSaleDbContext _context = _contextFactory.CreateDbContext())
                {
                    var entity = _mapper.Map<M, T>(dto);

                    if (id is null) await _context.Set<T>().AddAsync(entity);
                    else
                    {
                        // var dbEntity = await FindById(id);
                        // if(dbEntity is not null) 
                            _context.Entry(entity).State = EntityState.Modified;
                    }

                    await _context.SaveChangesAsync();

                    return _mapper.Map<T, M>(entity);
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
                        await _context.SaveChangesAsync();

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