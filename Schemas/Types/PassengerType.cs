using ticket_store_api.Models.Externals;

namespace ticket_store_api.Schemas.Types
{
    [GraphQLName("Passenger")]
    public class PassengerType
    {
        public long Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required DateTime BirthDate { get; set; }
        public required string Gender { get; set; }
        public required string Email { get; set; }
        public required string CountryCode { get; set; }
        public required string Telephone { get; set; }
        public required string Address { get; set; }
        public required string Unit { get; set; }
        public required string PostalCode { get; set; }
        public int CityId { get; set; }

        //TO-DO
        // public City City()
        // {
        //     return null;
        // }
    }
}