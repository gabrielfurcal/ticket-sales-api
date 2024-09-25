using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ticket_store_api.Models.Externals;

namespace ticket_store_api.Models
{
    [Table("Tickets")]
    public class Ticket
    {
        [Key]
        [Column("Ticket_ID")]
        public Guid Id { get; set; }

        public required string Seat { get; set; }

        [ForeignKey("Passenger_ID")]
        public required long PassengerId { get; set; }

        [ForeignKey("Ticket_Type_ID")]
        public required int TicketTypeId { get; set; }
        
        [Column("Schedule_ID")]
        public int ScheduleId { get; set; }

        [ForeignKey("Transaction_ID")]
        public Guid TransactionId { get; set; }

        public bool Checked { get; set; }
        
        public virtual required Passenger Passenger { get; set; }
        public virtual required TicketType TicketType { get; set; }
        public virtual required Transaction Transaction { get; set; }
        public virtual Schedule? Schedule { get; set; }
    }
}