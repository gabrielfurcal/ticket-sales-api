using AutoMapper;
using ticket_store_api.GraphQL.Schema.Types;

namespace ticket_store_api.Profiles
{
    public class ScheduleProfile : Profile
    {
        public ScheduleProfile()
        {
            CreateMap<IGetScheduleById_ScheduleById, ScheduleType>();
            CreateMap<ScheduleType, IGetScheduleById_ScheduleById>();
        }
    }
}