using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.GraphQL.Schema.Types;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.GraphQL.Schema.Queries
{
    [ExtendObjectType(nameof(BaseQueries))]
    public class TicketQueries
    {
        private readonly ITicketService _ticketService;
        private readonly IMapper _mapper;

        public TicketQueries(ITicketService ticketService, IMapper mapper)
        {
            this._ticketService = ticketService;
            this._mapper = mapper;
        }
        
        public async Task<List<TicketType>> GetTickets()
        {
            List<TicketDTO> dtoTickets =  await _ticketService.FindAll();
            return dtoTickets.Select(t => _mapper.Map<TicketDTO, TicketType>(t)).ToList();
        }

        public async Task<TicketType?> GetTicketById(Guid id)
        {
            TicketDTO dtoTicket = await _ticketService.FindById(id);
            return _mapper.Map<TicketDTO, TicketType>(dtoTicket);
        }
    }
}