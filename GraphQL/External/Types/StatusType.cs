namespace ticket_store_api.GraphQL.External.Types
{
    [GraphQLName("Status")]
    public class StatusType
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}