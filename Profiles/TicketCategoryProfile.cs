using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.Models;

namespace ticket_store_api.Profiles 
{
    public class TicketCategoryProfile : Profile
    {
        public TicketCategoryProfile()
        {
            CreateMap<TicketCategory, TicketCategoryDTO>();
            CreateMap<TicketCategoryDTO, TicketCategory>();
        }
    }
}