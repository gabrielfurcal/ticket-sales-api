using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ticket_store_api.Models
{
    [Table("Tickets")]
    public class Ticket
    {
        [Key]
        public Guid Id {get; set;}

        public required string Seat {get;set;}

        [ForeignKey("passengerId")]
        public required long PassengerId {get;set;}

        [ForeignKey("ticketTypeId")]
        public required int TicketTypeId {get;set;}
        
        // [ForeignKey("scheduleId")]
        public int ScheduleId {get;set;}

        [ForeignKey("transactionId")]
        public Guid TransactionId {get;set;}

        public bool Checked {get;set;}
        
        public virtual required Passenger Passenger {get;set;}
        public virtual required TicketType TicketType {get;set;}
        public virtual required Transaction Transaction {get;set;}
    }
}