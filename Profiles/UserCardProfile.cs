using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.Models;
using ticket_store_api.Schemas.Types;

namespace ticket_store_api.Profiles
{
    public class UserCardProfile : Profile
    {
        public UserCardProfile()
        {
            CreateMap<UserCard, UserCardDTO>();
            CreateMap<UserCardDTO, UserCard>();

            CreateMap<UserCardType, UserCardDTO>();
            CreateMap<UserCardDTO, UserCardType>();

            CreateMap<UserCardInputType, UserCardDTO>();
            CreateMap<UserCardDTO, UserCardInputType>();
        }
    }
}