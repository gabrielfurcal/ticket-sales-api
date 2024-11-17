using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ticket_store_api.DTOs;
using ticket_store_api.Models;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Services.Implementations
{
    public class UserCardService : BaseService<UserCard, int?, UserCardDTO>, IUserCardService
    {
        public UserCardService(IDbContextFactory<TicketSaleDbContext> contextFactory, IMapper mapper) : base(contextFactory, mapper)
        {
        }
    }
}