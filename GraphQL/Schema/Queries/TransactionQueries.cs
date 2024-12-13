using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.GraphQL.Schema.Types;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.GraphQL.Schema.Queries
{
    [ExtendObjectType(nameof(BaseQueries))]
    public class TransactionQueries
    {
        private readonly ITransactionService _transactionService;
        private readonly IMapper _mapper;

        public TransactionQueries(ITransactionService transactionService, IMapper mapper)
        {
            this._transactionService = transactionService;
            this._mapper = mapper;
        }
        
        public async Task<List<TransactionType>> GetTransactions()
        {
            List<TransactionDTO> dtoTransactions = await _transactionService.FindAll();
            return dtoTransactions.Select(t => _mapper.Map<TransactionDTO, TransactionType>(t)).ToList();
        }

        public async Task<TransactionType?> GetTransactionById(Guid id)
        {
            TransactionDTO dtoTransaction = await _transactionService.FindById(id);
            return _mapper.Map<TransactionDTO, TransactionType>(dtoTransaction);
        }
    }
}