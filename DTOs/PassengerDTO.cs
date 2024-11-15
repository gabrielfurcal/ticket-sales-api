using ticket_store_api.Models.Externals;

namespace ticket_store_api.DTOs
{
    public record PassengerDTO(long? Id, string FirstName, string LastName, DateTime BirthDate, string Gender, string Email, string CountryCode, string Telephone, string Address, string Unit, string PostalCode, int? CityId, City? city);
}