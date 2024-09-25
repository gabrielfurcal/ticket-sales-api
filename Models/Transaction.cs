using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ticket_store_api.Models
{
    [Table("Transactions")]
    public class Transaction
    {
        [Key]
        public Guid Id {get;set;}

        public DateTime RegisteredAt {get;set;}

        public required string Method {get;set;}

        public decimal Amount {get;set;}

        public string? CardHolderName {get;set;}

        [StringLength(16)]
        public string? CardNumber {get;set;}

        public int? CardExpirationDateMonth {get;set;}

        public int? CardExpirationDateYear {get;set;}

        public int? CVV {get;set;}

        [ForeignKey("userCardId")]
        public int? UserCardId {get;set;}

        public virtual required UserCard UserCard {get;set;}
    }
}