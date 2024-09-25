using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ticket_store_api.Models
{
    [Table("TicketTypes")]
    public class TicketType
    {
        [Key]
        public int Id {get;set;}
        public required TicketCategory TicketCategory {get;set;}
        public decimal SalePrice {get;set;}
        public decimal? DiscountPercentage {get;set;}
        public int RouteId {get;set;}
    }
}