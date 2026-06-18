using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.GraphQL.Schema.InputTypes;
using ticket_store_api.GraphQL.Schema.Types;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.GraphQL.Schema.Mutations
{
    [ExtendObjectType(nameof(BaseMutations))]
    public class TicketMutations
    {
        private readonly ITicketService _ticketService;
        private readonly IMapper _mapper;

        public TicketMutations(ITicketService ticketService, IMapper mapper)
        {
            this._ticketService = ticketService;
            this._mapper = mapper;
        }

        public async Task<TicketType?> SaveTicket(TicketInputType ticket)
        {
            TicketDTO dtoTicket = await _ticketService.Save(_mapper.Map<TicketInputType, TicketDTO>(ticket), ticket.Id);
            return _mapper.Map<TicketDTO, TicketType>(dtoTicket); 
        }

        public async Task<bool> DeleteTicket(Guid id)
        {
            return await _ticketService.DeleteById(id);
        }
    }
}