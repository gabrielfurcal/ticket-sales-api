using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ticket_store_api.DTOs;
using ticket_store_api.Models;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Services.Implementations
{
    public class PassengerService : BaseService<Passenger, long?, PassengerDTO>, IPassengerService
    {
        public PassengerService(IDbContextFactory<TicketSaleDbContext> contextFactory, IMapper mapper) : base(contextFactory, mapper)
        {
        }
    }
}