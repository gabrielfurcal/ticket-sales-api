namespace ticket_store_api.Schemas.Types
{
    [GraphQLName("TicketCategoryInput")]
    public class TicketCategoryInputType
    {
        public int? Id { get; set; }
        public required string Name { get; set; }
    }
}