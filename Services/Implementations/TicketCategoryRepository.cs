using Microsoft.EntityFrameworkCore;
using ticket_store_api.Models;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Services.Implementations
{
    public class TicketCategoryRepository : BaseRepository<TicketCategory, int>, ITicketCategoryRepository
    {
        public TicketCategoryRepository(IDbContextFactory<TicketSaleDbContext> contextFactory) : base(contextFactory)
        {
        }
    }
}