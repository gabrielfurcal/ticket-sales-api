using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ticket_store_api.Models;

namespace ticket_store_api.Services
{
    public class TicketSaleDbContext : DbContext
    {
        public TicketSaleDbContext(DbContextOptions<TicketSaleDbContext> options)
            : base(options)
        {   
        }

        public required DbSet<Passenger> Passenger {get;set;}
        public required DbSet<Ticket> Ticket {get;set;}
        public required DbSet<TicketCategory> TicketCategory {get;set;}
        public required DbSet<Transaction> Transaction {get;set;}
        public required DbSet<UserCard> UserCard {get;set;}
    }
}