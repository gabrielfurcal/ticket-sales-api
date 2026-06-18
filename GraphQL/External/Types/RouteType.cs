using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.GraphQL.Schema.Types;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.GraphQL.External.Types
{
    [GraphQLName("Route")]
    public class RouteType
    {
        public int? Id { get; set; }

        [GraphQLIgnore]
        public int? StartStationId { get; set; }

        [GraphQLIgnore]
        public int? EndStationId { get; set; }

        public float? Distance { get; set; }

        public StationType? StartStation { get; set; }

        public StationType? EndStation { get; set; }

        public async Task<List<TicketTypeType>> TicketType([Parent] RouteType route, [Service] ITicketTypeService query, [Service] IMapper mapper)
        {
            int routeId = Convert.ToInt32(route.Id);

            var result = await query.FindFilteringList(x => x.RouteId == routeId);

            var ticketTypeType = mapper.Map<List<TicketTypeDTO>, List<TicketTypeType>>(result);

            return ticketTypeType;
        }

    }
}