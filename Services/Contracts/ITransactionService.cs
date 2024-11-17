using System.Transactions;
using ticket_store_api.DTOs;

namespace ticket_store_api.Services.Contracts
{
    public interface ITransactionService : IBaseService<Transaction, Guid?, TransactionDTO>
    {   
    }
}