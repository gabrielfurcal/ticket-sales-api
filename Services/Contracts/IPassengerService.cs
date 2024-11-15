using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ticket_store_api.DTOs;
using ticket_store_api.Models;

namespace ticket_store_api.Services.Contracts
{
    public interface IPassengerService : IBaseService<Passenger, long?, PassengerDTO>
    {
        
    }
}