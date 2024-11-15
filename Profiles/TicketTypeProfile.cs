using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.Models;

namespace ticket_store_api.Profiles
{
    public class TicketTypeProfile : Profile
    {
        public TicketTypeProfile()
        {
            CreateMap<TicketType, TicketTypeDTO>();
            CreateMap<TicketTypeDTO, TicketType>();
        }
    }
}