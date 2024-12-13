namespace ticket_store_api.GraphQL.External.Types
{
    public class TrainType
    {
        public int Id { get; set; }
        public required string Capacity { get; set; }
        public required float maxSpeed { get; set; }
    }
}