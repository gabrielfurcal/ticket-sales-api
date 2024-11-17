using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ticket_store_api.DTOs;
using ticket_store_api.Models;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Services.Implementations
{
    public class TicketTypeService : BaseService<TicketType, int?, TicketTypeDTO>, ITicketTypeService
    {
        public TicketTypeService(IDbContextFactory<TicketSaleDbContext> contextFactory, IMapper mapper) : base(contextFactory, mapper)
        {
        }
    }
}