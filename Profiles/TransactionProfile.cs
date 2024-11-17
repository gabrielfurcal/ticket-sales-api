using System.Transactions;
using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.Schemas.Types;

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