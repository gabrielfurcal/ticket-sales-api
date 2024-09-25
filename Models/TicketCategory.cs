using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ticket_store_api.Models
{
    [Table("TicketCategories")]
    public class TicketCategory
    {
        [Key]
        [Column("Ticket_Cat_ID")]
        public int Id { get; set; }

        public required string Name { get; set; }
    }
}