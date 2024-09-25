using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ticket_store_api.Models
{
    [Table("Transactions")]
    public class Transaction
    {
        [Key]
        [Column("Transaction_ID")]
        public Guid Id { get; set; }

        [Column("Registered_At")]
        public DateTime RegisteredAt { get; set; }

        public required string Method { get; set; }

        public decimal Amount { get; set; }

        [Column("Cardholder_Name")]
        public string? CardHolderName { get; set; }

        [Column("Card_Number")]
        [StringLength(16)]
        public string? CardNumber { get; set; }

        [Column("Expiration_Month")]
        public short? CardExpirationMonth { get; set; }

        [Column("Expiration_Year")]
        public short? CardExpirationYear { get; set; }

        public short? CVV { get; set; }

        [ForeignKey("User_Card_ID")]
        public int? UserCardId { get; set; }

        public virtual UserCard? UserCard { get; set; }
    }
}