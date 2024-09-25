using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ticket_store_api.Models
{
    [Table("TicketTypes")]
    public class TicketType
    {
        [Key]
        [Column("Ticket_Type_ID")]
        public int Id { get; set; }

        [ForeignKey("Ticket_Cat_ID")]
        public int TicketCategoryId { get; set; }

        [Column("Sale_Price")]
        public decimal SalePrice { get; set; }

        [Column("Discount_Percentage")]
        public decimal? DiscountPercentage { get; set; }

        [Column("Route_ID")]
        public int RouteId { get; set; }

        public virtual required TicketCategory TicketCategory { get; set; }
        
        public virtual Externals.Route? Route { get; set; }
    }
}