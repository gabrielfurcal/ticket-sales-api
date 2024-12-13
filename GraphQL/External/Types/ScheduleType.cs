namespace ticket_store_api.GraphQL.External.Types
{
    public class ScheduleType
    {
        public int Id { get; set; }

        [GraphQLIgnore]
        public int TrainId { get; set; }

        [GraphQLIgnore]
        public int RouteId { get; set; }

        [GraphQLIgnore]
        public int StatusId { get; set; }

        public required string DepartureTime { get; set; }
        public required string ArrivalTime { get; set; }
    }
}