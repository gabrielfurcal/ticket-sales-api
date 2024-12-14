namespace ticket_store_api.GraphQL.External.Types
{
    [GraphQLName("Train")]
    public class TrainType
    {
        public int? Id { get; set; }
        public string? Type { get; set; }
        public string? Capacity { get; set; }
        public float? maxSpeed { get; set; }
    }
}