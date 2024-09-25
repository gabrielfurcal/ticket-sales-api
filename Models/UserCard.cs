using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ticket_store_api.Models.Externals;

namespace ticket_store_api.Models
{
    [Table("UserCards")]
    public class UserCard
    {
        [Key] 
        [Column("User_Card_ID")]
        public int Id { get; set; }

        [Column("Cardholder_Name")]
        public required string CardHolderName { get; set; }

        [Column("Card_Number")]
        [StringLength(16)]
        public required string CardNumber { get; set; }

        [Column("Expiration_Month")]
        public short ExpirationMonth { get; set; }

        [Column("Expiration_Year")]
        public short ExpirationYear { get; set; }

        public short CVV { get; set; }
        
        // [ForeignKey("userId")]
        [Column("User_ID")]
        public int UserId { get; set; }

        public virtual User? User { get; set; }
    }
}