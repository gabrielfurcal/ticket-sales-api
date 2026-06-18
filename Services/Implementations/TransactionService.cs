using System.Transactions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ticket_store_api.DTOs;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Services.Implementations
{
    public class TransactionService : BaseService<Transaction, Guid?, TransactionDTO>, ITransactionService
    {
        public TransactionService(IDbContextFactory<TicketSaleDbContext> contextFactory, IMapper mapper) : base(contextFactory, mapper)
        {
        }
    }
}