using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.Schemas.Types;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Schemas.Mutations
{
    [ExtendObjectType(nameof(BaseMutations))]
    public class TicketCategoryMutations
    {
        private readonly ITicketCategoryService _ticketCategoryService;
        private readonly IMapper _mapper;

        public TicketCategoryMutations(ITicketCategoryService ticketCategoryService, IMapper mapper)
        {
            this._ticketCategoryService = ticketCategoryService;
            this._mapper = mapper;
        }

        public async Task<TicketCategoryType?> SaveTicketCategory(TicketCategoryInputType ticketCategory)
        {
            TicketCategoryDTO dtoTicketCategory = await _ticketCategoryService
                .Save(_mapper.Map<TicketCategoryInputType, TicketCategoryDTO>(ticketCategory), ticketCategory.Id);
            return _mapper.Map<TicketCategoryDTO, TicketCategoryType>(dtoTicketCategory);
        }

        public async Task<bool> DeleteTicketCategory(int id)
        {
            return await _ticketCategoryService.DeleteById(id);
        }
    }
}