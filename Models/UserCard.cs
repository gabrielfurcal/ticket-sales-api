using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ticket_store_api.Models
{
    [Table("UserCards")]
    public class UserCard
    {
        [Key] 
        public int Id {get;set;}

        public required string CardHolderName {get;set;}

        [StringLength(16)] 
        public required string CardNumber {get;set;}

        public short ExpirationMonth {get;set;}

        public short ExpirationYear {get;set;}

        public short CVV {get;set;}
        
        // [ForeignKey("userId")]
        public int UserId {get;set;}
    }
}