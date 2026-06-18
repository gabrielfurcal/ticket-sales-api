namespace ticket_store_api.GraphQL.External.Types
{
    [GraphQLName("User")]
    public class UserType
    {
        public int? Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}