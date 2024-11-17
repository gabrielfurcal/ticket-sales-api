using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.Schemas.Types;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Schemas.Queries
{
    [ExtendObjectType("Query")]
    public class TicketTypeQueries
    {
        private readonly ITicketTypeService _ticketTypeService;
        private readonly IMapper _mapper;

        public TicketTypeQueries(ITicketTypeService ticketTypeService, IMapper mapper)
        {
            this._ticketTypeService = ticketTypeService;
            this._mapper = mapper;
        }
        
        public async Task<List<TicketTypeType>> GetTicketTypes()
        {
            List<TicketTypeDTO> dtoTicketTypes = await _ticketTypeService.FindAll();
            return dtoTicketTypes.Select(tt => _mapper.Map<TicketTypeDTO, TicketTypeType>(tt)).ToList();
        }

        public async Task<TicketTypeType?> GetTicketTypeById(int id)
        {
            TicketTypeDTO dtoTicketType = await _ticketTypeService.FindById(id);
            return _mapper.Map<TicketTypeDTO, TicketTypeType>(dtoTicketType);
        }
    }
}