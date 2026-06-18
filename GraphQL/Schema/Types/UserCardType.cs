namespace ticket_store_api.GraphQL.Schema.Types
{
    [GraphQLName("UserCard")]
    public class UserCardType
    {
        public int Id { get; set; }
        public required string CardHolderName { get; set; }
        public required string CardNumber { get; set; }
        public short ExpirationMonth { get; set; }
        public short ExpirationYear { get; set; }
        public short CVV { get; set; }
        public int UserId { get; set; }
    }
}