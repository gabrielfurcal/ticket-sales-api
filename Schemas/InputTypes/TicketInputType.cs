namespace ticket_store_api.Schemas.Types
{
    [GraphQLName("TicketInput")]
    public class TicketInputType
    {
        public Guid? Id { get; set; }
        public required string Seat { get; set; }
        public bool Checked { get; set; }
        public required long PassengerId { get; set; }
        public required int TicketTypeId { get; set; }
        public required int TicketCategoryId { get; set; }
        public required int TransactionId { get; set; }
        public required int ScheduleId { get; set; }
    }
}