using AutoMapper;

namespace ticket_store_api.GraphQL.Schema.Types
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

        [GraphQLIgnore]
        public int CityId { get; set; }

        public async Task<CityType> City([Service] GetCityByIdQuery query, [Service] IMapper mapper)
        {
            var result = await query.ExecuteAsync(this.CityId);
            var city = result.Data?.CityById;

            var cityType = mapper.Map<IGetCityById_CityById, CityType>(city!);

            return cityType;
        }
    }
}