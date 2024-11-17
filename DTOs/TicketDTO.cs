namespace ticket_store_api.DTOs
{
    public record TicketDTO(Guid? Id, string Seat, bool Checked, long? PassengerId, int? TicketTypeId, int? ScheduleId, Guid? TransactionId);
}