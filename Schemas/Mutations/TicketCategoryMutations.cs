using ticket_store_api.DTOs;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Schemas.Mutations
{
    [ExtendObjectType(typeof(Mutation))]
    public class TicketCategoryMutations
    {
        private readonly ITicketCategoryService _ticketCategoryService;

        public TicketCategoryMutations(ITicketCategoryService ticketCategoryService)
        {
            this._ticketCategoryService = ticketCategoryService;
        }

        public async Task<TicketCategoryDTO?> SaveTicketCategory(TicketCategoryDTO ticketCategory)
        {
            return await _ticketCategoryService.Save(ticketCategory, ticketCategory.Id);
        }

        public async Task<bool> DeleteTicketCategory(int id)
        {
            return await _ticketCategoryService.DeleteById(id);
        }
    }
}