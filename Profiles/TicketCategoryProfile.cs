using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.Models;
using ticket_store_api.GraphQL.Schema.Types;
using ticket_store_api.GraphQL.Schema.InputTypes;

namespace ticket_store_api.Profiles 
{
    public class TicketCategoryProfile : Profile
    {
        public TicketCategoryProfile()
        {
            CreateMap<TicketCategory, TicketCategoryDTO>();
            CreateMap<TicketCategoryDTO, TicketCategory>();

            CreateMap<TicketCategoryType, TicketCategoryDTO>();
            CreateMap<TicketCategoryDTO, TicketCategoryType>();

            CreateMap<TicketCategoryInputType, TicketCategoryDTO>();
            CreateMap<TicketCategoryDTO, TicketCategoryInputType>();
        }
    }
}