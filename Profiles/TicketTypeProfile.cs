using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.GraphQL.Schema.Types;
using ticket_store_api.GraphQL.Schema.InputTypes;

namespace ticket_store_api.Profiles
{
    public class TicketTypeProfile : Profile
    {
        public TicketTypeProfile()
        {
            CreateMap<Models.TicketType, TicketTypeDTO>();
            CreateMap<TicketTypeDTO, Models.TicketType>();

            CreateMap<TicketTypeType, TicketTypeDTO>();
            CreateMap<TicketTypeDTO, TicketTypeType>();

            CreateMap<TicketTypeInputType, TicketTypeDTO>();
            CreateMap<TicketTypeDTO, TicketTypeInputType>();
        }
    }
}