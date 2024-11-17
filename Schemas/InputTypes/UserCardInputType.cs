namespace ticket_store_api.Schemas.Types
{
    [GraphQLName("UserCardInput")]
    public class UserCardInputType
    {
        public int? Id { get; set; }
        public required string CardHolderName { get; set; }
        public required string CardNumber { get; set; }
        public short ExpirationMonth { get; set; }
        public short ExpirationYear { get; set; }
        public short CVV { get; set; }
        public int UserId { get; set; }
    }
}