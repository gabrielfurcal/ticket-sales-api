using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.Schemas.Types;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Schemas.Mutations
{
    [ExtendObjectType("Mutation")]
    public class TicketTypeMutations
    {
        private readonly ITicketTypeService _ticketTypeService;
        private readonly IMapper _mapper;

        public TicketTypeMutations(ITicketTypeService ticketTypeService, IMapper mapper)
        {
            this._ticketTypeService = ticketTypeService;
            this._mapper = mapper;
        }

        public async Task<TicketTypeType?> SaveTicketType(TicketTypeInputType ticketType)
        {
            TicketTypeDTO dtoTicketType = await _ticketTypeService.Save(_mapper.Map<TicketTypeInputType, TicketTypeDTO>(ticketType), ticketType.Id);
            return _mapper.Map<TicketTypeDTO, TicketTypeType>(dtoTicketType);
        }

        public async Task<bool> DeleteTicketType(int id)
        {
            return await _ticketTypeService.DeleteById(id);
        }
    }
}