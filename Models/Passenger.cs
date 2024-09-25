using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ticket_store_api.Models.Externals;

namespace ticket_store_api.Models
{
    [Table("Passengers")]
    public class Passenger
    {
        [Key]
        [Column("Passenger_ID")]
        public long Id { get; set; }

        [Column("First_Name")]
        public required string FirstName { get; set; }

        [Column("Last_Name")]
        public required string LastName { get; set; }

        [Column("Birth_Date")]
        public DateTime BirthDate {get; set;}

        public char Gender { get; set; }

        public required string Email { get; set; }

        [Column("Country_Code")]
        public required string CountryCode { get; set; }

        [Column("Phone_Number")]
        public required string Telephone { get; set; }

        public required string Address { get; set;}

        public required string Unit { get; set; }

        [Column("Postal_Code")]
        public required string PostalCode { get; set; }

        [Column("City_ID")]
        public int? CityId { get; set; }

        public virtual City? City { get; set; }
    }
}