using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.Models;

namespace ticket_store_api.Profiles
{
    public class PassengerProfile : Profile
    {
        public PassengerProfile()
        {
            CreateMap<Passenger, PassengerDTO>();
            CreateMap<PassengerDTO, Passenger>();
        }
    }
}