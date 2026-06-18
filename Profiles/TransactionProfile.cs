using System.Transactions;
using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.GraphQL.Schema.Types;
using ticket_store_api.GraphQL.Schema.InputTypes;

namespace ticket_store_api.Profiles
{
    public class TransactionProfile : Profile
    {
        public TransactionProfile()
        {
            CreateMap<Transaction, TransactionDTO>();
            CreateMap<TransactionDTO, Transaction>();

            CreateMap<TransactionType, TransactionDTO>();
            CreateMap<TransactionDTO, TransactionType>();

            CreateMap<TransactionInputType, TransactionDTO>();
            CreateMap<TransactionDTO, TransactionInputType>();
        }
    }
}