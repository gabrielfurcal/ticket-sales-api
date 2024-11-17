using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.Schemas.Types;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Schemas.Mutations
{
    [ExtendObjectType("Mutation")]
    public class TransactionMutations
    {
        private readonly ITransactionService _transactionService;
        private readonly IMapper _mapper;

        public TransactionMutations(ITransactionService transactionService, IMapper mapper)
        {
            this._transactionService = transactionService;
            this._mapper = mapper;
        }

        public async Task<TransactionType?> SaveTransaction(TransactionInputType transaction)
        {
            TransactionDTO dtoTransaction = await _transactionService.Save(_mapper.Map<TransactionInputType, TransactionDTO>(transaction), transaction.Id);
            return _mapper.Map<TransactionDTO, TransactionType>(dtoTransaction);
        }

        public async Task<bool> DeleteTransaction(Guid id)
        {
            return await _transactionService.DeleteById(id);
        }
    }
}