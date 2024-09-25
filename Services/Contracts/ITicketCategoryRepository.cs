using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ticket_store_api.Models;

namespace ticket_store_api.Services.Contracts
{
    public interface ITicketCategoryRepository : IBaseRepository<TicketCategory, int>
    {
        
    }
}