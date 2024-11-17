namespace ticket_store_api.Schemas.Types
{
    [GraphQLName("TicketCategory")]
    public class TicketCategoryType
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}