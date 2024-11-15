namespace ticket_store_api.DTOs
{
    public record TicketTypeDTO(int? Id, int? TicketCategoryId, decimal SalePrice, decimal? DiscountPercentage, int? RouteId, TicketCategoryDTO? TicketCategory, Models.Externals.Route? route);
}