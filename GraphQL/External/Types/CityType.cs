namespace ticket_store_api.GraphQL.External.Types
{
    [GraphQLName("City")]
    public class CityType
    {
        public int? Id { get; set; }
        public string? City { get; set; }
        public string? Province { get; set; }
        public string? Country { get; set; }
    }
}