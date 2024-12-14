namespace ticket_store_api.GraphQL.External.Types
{
    [GraphQLName("Route")]
    public class RouteType
    {
        public int? Id { get; set; }

        [GraphQLIgnore]
        public int? StartStationId { get; set; }

        [GraphQLIgnore]
        public int? EndStationId { get; set; }
        
        public float? Distance { get; set; }
        public StationType? StartStation { get; set; }
        public StationType? EndStation { get; set; }
    }
}