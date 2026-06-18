using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.Models;
using ticket_store_api.GraphQL.Schema.InputTypes;

namespace ticket_store_api.Profiles
{
    public class TicketProfile : Profile
    {
        public TicketProfile()
        {
            CreateMap<Ticket, TicketDTO>();
            CreateMap<TicketDTO, Ticket>();

            CreateMap<GraphQL.Schema.Types.TicketType, TicketDTO>();
            CreateMap<TicketDTO, GraphQL.Schema.Types.TicketType>();

            CreateMap<TicketInputType, TicketDTO>();
            CreateMap<TicketDTO, TicketInputType>();
        }
    }
}