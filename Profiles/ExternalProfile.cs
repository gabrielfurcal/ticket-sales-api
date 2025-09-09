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
                .ForMember(dest => dest.StartStation, act => act.MapFrom(src => new StationType 
                { 
                    Name = src.StartStation!.Name 
                }))
                .ForMember(dest => dest.EndStation, act => act.MapFrom(src => new StationType 
                { 
                    Name = src.EndStation!.Name 
                }));
            CreateMap<RouteType, IGetRouteById_RouteById>();

            // Schedule
            CreateMap<IGetScheduleById_ScheduleById, ScheduleType>()
                .ForMember(dest => dest.Train, act => act.MapFrom(src => new TrainType { Type = src.Train!.Type }))
                .ForMember(dest => dest.Status, act => act.MapFrom(src => new StatusType { Name = src.Status!.Name }))
                .ForMember(dest => dest.Route, act => act.MapFrom(src => new RouteType 
                { 
                    StartStation = new StationType { Name = src.Route!.StartStation!.Name, ImageUrl = src.Route!.StartStation!.ImageUrl },
                    EndStation = new StationType { Name = src.Route!.EndStation!.Name, ImageUrl = src.Route!.EndStation!.ImageUrl }
                }));

            CreateMap<IGetSchedules_Schedules, ScheduleType>()
                .ForMember(dest => dest.Train, act => act.MapFrom(src => new TrainType { Type = src.Train!.Type }))
                .ForMember(dest => dest.Status, act => act.MapFrom(src => new StatusType { Name = src.Status!.Name }))
                .ForMember(dest => dest.Route, act => act.MapFrom(src => new RouteType 
                {
                    Id = Convert.ToInt32(src.Route!.Id),
                    Distance = (float) src.Route!.Distance!,
                    StartStation = new StationType
                    {
                        Name = src.Route!.StartStation!.Name,
                        City = new CityType { City = src.Route!.StartStation!.City!.City, Province = src.Route!.StartStation!.City!.Province }
                    },
                    EndStation = new StationType
                    {
                        Name = src.Route!.EndStation!.Name,
                        City = new CityType { City = src.Route!.EndStation!.City!.City, Province = src.Route!.EndStation!.City!.Province }
                    }
                }));

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