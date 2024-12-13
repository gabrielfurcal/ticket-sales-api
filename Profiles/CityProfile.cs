using AutoMapper;
using ticket_store_api.GraphQL.Schema.Types;

namespace ticket_store_api.Profiles
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<IGetCityById_CityById, CityType>();
            CreateMap<CityType, IGetCityById_CityById>();
        }
    }
}