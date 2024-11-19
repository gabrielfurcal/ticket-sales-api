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
        public Guid? Id { get; set; }

        public required string Seat { get; set; }

        [Column("Passenger_ID")]
        [ForeignKey("PassengerId")]
        public required long PassengerId { get; set; }

        [Column("Ticket_Type_ID")]
        [ForeignKey("TicketTypeId")]
        public required int TicketTypeId { get; set; }
        
        [Column("Schedule_ID")]
        public int ScheduleId { get; set; }

        [Column("Transaction_ID")]
        [ForeignKey("TransactionId")]
        public Guid TransactionId { get; set; }

        public bool Checked { get; set; }
        
        public virtual required Passenger Passenger { get; set; }
        public virtual required TicketType TicketType { get; set; }
        public virtual required Transaction Transaction { get; set; }
        public virtual Schedule? Schedule { get; set; }
    }
}