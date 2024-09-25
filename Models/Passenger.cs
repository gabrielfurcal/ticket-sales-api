using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ticket_store_api.Models
{
    [Table("Passengers")]
    public class Passenger
    {
        [Key]
        public long Id {get;set;}
        public required string FirstName {get;set;}
        public required string LastName {get;set;}
        public DateTime BirthDate {get;set;}
        public char Gender {get; set;}
        public required string Address { get; set;}
        public required string Telephone {get; set;}
        public required string Email {get;set;}
    }
}