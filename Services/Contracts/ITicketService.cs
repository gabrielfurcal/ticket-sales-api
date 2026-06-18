using ticket_store_api.DTOs;
using ticket_store_api.Models;

namespace ticket_store_api.Services.Contracts
{
    public interface ITicketService : IBaseService<Ticket, Guid?, TicketDTO>
    { }
}