namespace ticket_store_api.GraphQL.Schema.InputTypes
{
    [GraphQLName("TransactionInput")]
    public class TransactionInputType
    {
        public Guid Id { get; set; }
        public DateTime RegisteredAt { get; set; }
        public required string Method { get; set; }
        public decimal Amount { get; set; }
        public required string CardNumber { get; set; }
        public short CardExpirationMonth { get; set; }
        public short CardExpirationYear { get; set; }
        public short CVV { get; set; }
        public int UserCardId { get; set; }
    }
}