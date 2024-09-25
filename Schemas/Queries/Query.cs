using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ticket_store_api.Models;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Schemas.Queries
{
    public class Query
    {
        private readonly ITicketCategoryRepository _ticketCategoryRepository;

        public Query(ITicketCategoryRepository ticketCategoryRepository)
        {
            this._ticketCategoryRepository = ticketCategoryRepository;
        }

        public async Task<List<TicketCategoryType>> GetTicketCategories()
        {
            List<TicketCategory> categories = await _ticketCategoryRepository.FindAll();
            return categories.Select(cat => new TicketCategoryType(cat.Id, cat.Name)).ToList();
        }
    }
}