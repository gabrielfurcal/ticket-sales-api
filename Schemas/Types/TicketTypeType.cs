using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Schemas.Types
{
    [GraphQLName("TicketType")]
    public class TicketTypeType
    {
        public int Id { get; set; }
        public decimal SalePrice { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public int RouteId { get; set; }

        [GraphQLIgnore]
        public int TicketCategoryId { get; set; }

        public async Task<TicketCategoryType> TicketCategory([Service] ITicketCategoryService _ticketCategoryService, IMapper _mapper)
        {
            TicketCategoryDTO dtoTicketCategory = await _ticketCategoryService.FindById(this.TicketCategoryId);
            return _mapper.Map<TicketCategoryDTO, TicketCategoryType>(dtoTicketCategory);
        }
    }
}