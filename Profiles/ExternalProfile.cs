using AutoMapper;
using ticket_store_api.GraphQL.External.Types;

namespace ticket_store_api.Profiles
{
    public class ExternalProfile : Profile
    {
        public ExternalProfile()
        {
            // City
            CreateMap<IGetCityById_CityById, CityType>();
            CreateMap<CityType, IGetCityById_CityById>();

            // Route
            CreateMap<IGetRouteById_RouteById, RouteType>()
                .ForMember(dest => dest.StartStation, act => act.MapFrom(src => src.StartStation))
                .ForMember(dest => dest.EndStation, act => act.MapFrom(src => src.EndStation));
            CreateMap<RouteType, IGetRouteById_RouteById>();

            // Schedule
            CreateMap<IGetScheduleById_ScheduleById, ScheduleType>()
                .ForMember(dest => dest.Route, act => act.MapFrom(src => src.Route))
                .ForMember(dest => dest.Status, act => act.MapFrom(src => src.Status))
                .ForMember(dest => dest.Train, act => act.MapFrom(src => src.Train));

            CreateMap<ScheduleType, IGetScheduleById_ScheduleById>(); 

            // Train
            CreateMap<IGetTrainById_TrainById, TrainType>();
            CreateMap<TrainType, IGetTrainById_TrainById>();

            // Station
            CreateMap<IGetStationById_StationById, StationType>();
            CreateMap<StationType, IGetStationById_StationById>();

            // Status
            CreateMap<IGetStatusById_StatusById, StatusType>();
            CreateMap<StatusType, IGetStatusById_StatusById>();
        }
    }
}