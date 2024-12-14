namespace ticket_store_api.GraphQL.External.Types
{
    [GraphQLName("Schedule")]
    public class ScheduleType
    {
        public int? Id { get; set; }

        [GraphQLIgnore]
        public int? TrainId { get; set; }

        [GraphQLIgnore]
        public int? RouteId { get; set; }

        [GraphQLIgnore]
        public int? StatusId { get; set; }

        public string? DepartureTime { get; set; }
        public string? ArrivalTime { get; set; }
        public TrainType? Train { get; set; }
        public RouteType? Route { get; set; }
        public StatusType? Status { get; set; }
    }
}