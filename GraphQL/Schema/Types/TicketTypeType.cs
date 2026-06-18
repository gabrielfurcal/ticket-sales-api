using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.GraphQL.External.Types;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.GraphQL.Schema.Types
{
    [GraphQLName("TicketType")]
    public class TicketTypeType
    {
        public int Id { get; set; }
        public decimal SalePrice { get; set; }
        public decimal? DiscountPercentage { get; set; }

        [GraphQLIgnore]
        public int RouteId { get; set; }

        public async Task<RouteType> Route([Service] GetRouteByIdQuery query, IMapper _mapper)
        {
            var result = await query.ExecuteAsync(this.RouteId);
            var route = result.Data?.RouteById!;
            var routeType = _mapper.Map<IGetRouteById_RouteById, RouteType>(route);
            
            return routeType;
        }

        [GraphQLIgnore]
        public int TicketCategoryId { get; set; }

        public async Task<TicketCategoryType> TicketCategory([Service] ITicketCategoryService _ticketCategoryService, IMapper _mapper)
        {
            TicketCategoryDTO dtoTicketCategory = await _ticketCategoryService.FindById(this.TicketCategoryId);
            return _mapper.Map<TicketCategoryDTO, TicketCategoryType>(dtoTicketCategory);
        }
    }
}