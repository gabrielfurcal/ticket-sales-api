using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ticket_store_api.DTOs;
using ticket_store_api.Models;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Services.Implementations
{
    public class TicketService : BaseService<Ticket, Guid?, TicketDTO>, ITicketService
    {
        public TicketService(IDbContextFactory<TicketSaleDbContext> contextFactory, IMapper mapper) : base(contextFactory, mapper)
        {
        }
    }
}