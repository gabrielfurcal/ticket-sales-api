namespace ticket_store_api.GraphQL.Schema.InputTypes
{
    [GraphQLName("TicketTypeInput")]
    public class TicketTypeInputType
    {
        public int? Id { get; set; }
        public decimal SalePrice { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public int RouteId { get; set; }
        public int TicketCategoryId { get; set; }
    }
}