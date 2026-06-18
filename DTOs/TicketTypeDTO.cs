namespace ticket_store_api.DTOs
{
    public record TicketTypeDTO(int? Id, decimal SalePrice, decimal? DiscountPercentage, int? TicketCategoryId, int? RouteId);
}