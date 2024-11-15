using ticket_store_api.DTOs;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Schemas.Queries
{
    [ExtendObjectType(typeof(Query))]
    public class TicketCategoryQueries
    {
        private readonly ITicketCategoryService _ticketCategoryService;

        public TicketCategoryQueries(ITicketCategoryService ticketCategoryService)
        {
            this._ticketCategoryService = ticketCategoryService;
        }
        
        public async Task<List<TicketCategoryDTO>> GetTicketCategories()
        {
            return await _ticketCategoryService.FindAll();
        }

        public async Task<TicketCategoryDTO?> GetTicketCategoryById(int id)
        {
            return await _ticketCategoryService.FindById(id);

        }
    }
}