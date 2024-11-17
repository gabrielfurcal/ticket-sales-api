using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.Schemas.Types;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Schemas.Queries
{
    [ExtendObjectType("Query")]
    public class TicketCategoryQueries
    {
        private readonly ITicketCategoryService _ticketCategoryService;
        private readonly IMapper _mapper;

        public TicketCategoryQueries(ITicketCategoryService ticketCategoryService, IMapper mapper)
        {
            this._ticketCategoryService = ticketCategoryService;
            this._mapper = mapper;
        }
        
        public async Task<List<TicketCategoryType>> GetTicketCategories()
        {
            List<TicketCategoryDTO> dtoTicketCategories = await _ticketCategoryService.FindAll();
            return dtoTicketCategories.Select(tc => _mapper.Map<TicketCategoryDTO, TicketCategoryType>(tc)).ToList();
        }

        public async Task<TicketCategoryType?> GetTicketCategoryById(int id)
        {
            TicketCategoryDTO dtoTicketCategory = await _ticketCategoryService.FindById(id);
            return _mapper.Map<TicketCategoryDTO, TicketCategoryType>(dtoTicketCategory);
        }
    }
}