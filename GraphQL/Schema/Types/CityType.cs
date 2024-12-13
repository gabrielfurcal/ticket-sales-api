namespace ticket_store_api.GraphQL.Schema.Types
{
    [GraphQLName("City")]
    public class CityType
    {
        public int Id { get; set; }
        public required string City { get; set; }
        public required string Province { get; set; }
        public required string Country { get; set; }
    }
}