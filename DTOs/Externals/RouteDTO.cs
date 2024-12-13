namespace ticket_store_api.DTOs.Externals
{
    public record RouteDTO(int Id, int StartStationId, int EndStationId, float Distance, StationDTO StartStation, StationDTO EndStation);
}