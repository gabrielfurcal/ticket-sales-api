namespace ticket_store_api.GraphQL.External.Types
{
    [GraphQLName("Station")]
    public class StationType
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? CountryCode { get; set; } 
        public string? Phone { get; set; }
        public string? PostalCode { get; set; }
        public float? Latitude { get; set; }
        public float? Longitude { get; set; }
        public int? cityId { get; set; }
        public string? imageUrl { get; set; }
    }
}