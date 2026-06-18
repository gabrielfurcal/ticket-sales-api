namespace ticket_store_api.GraphQL.Schema.InputTypes
{
    [GraphQLName("TicketCategoryInput")]
    public class TicketCategoryInputType
    {
        public int? Id { get; set; }
        public required string Name { get; set; }
    }
}