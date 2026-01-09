using AutoMapper;
using ticket_store_api.GraphQL.External.Types;
using ticket_store_api.GraphQL.Schema.Queries;

namespace ticket_store_api.GraphQL.External.Queries
{
    [ExtendObjectType(nameof(BaseQueries))]
    public class ScheduleQueries
    {
        private readonly IMapper _mapper;

        public ScheduleQueries(IMapper mapper)
        {
            this._mapper = mapper;
        }

        public async Task<List<ScheduleType>> GetSchedules([Service] GetSchedulesFilteredQuery query, int startStationId, int endStationId, string startDate, string endDate, int passengers)
        {
            try
            {
                var result = await query.ExecuteAsync(startStationId, endStationId, startDate, endDate, passengers);
                var schedules = result.Data?.SchedulesFiltered.ToList();

                var schedulesType = _mapper.Map<List<IGetSchedulesFiltered_SchedulesFiltered>, List<ScheduleType>>(schedules!);
                return schedulesType;
            }
            catch (Exception ex)
            {
                // Handle exception
                throw new GraphQLException("Error fetching schedules", ex);
            }
        }
    }
}