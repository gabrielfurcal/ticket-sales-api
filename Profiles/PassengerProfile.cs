using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.Models;
using ticket_store_api.GraphQL.Schema.Types;
using ticket_store_api.GraphQL.Schema.InputTypes;

namespace ticket_store_api.Profiles
{
    public class PassengerProfile : Profile
    {
        public PassengerProfile()
        {
            CreateMap<Passenger, PassengerDTO>();
            CreateMap<PassengerDTO, Passenger>();

            CreateMap<PassengerType, PassengerDTO>();
            CreateMap<PassengerDTO, PassengerType>();

            CreateMap<PassengerInputType, PassengerDTO>();
            CreateMap<PassengerDTO, PassengerInputType>();
        }
    }
}