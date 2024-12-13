namespace ticket_store_api.DTOs.Externals
{
    public record ScheduleDTO(int Id, int TrainId, int RouteId, int StatusId, string DepartureTime, string ArrivalTime, TrainDTO Train, RouteDTO Route, StatusDTO Status);
}