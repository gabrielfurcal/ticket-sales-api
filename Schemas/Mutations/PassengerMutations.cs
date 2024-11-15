using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ticket_store_api.DTOs;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Schemas.Mutations
{
    [ExtendObjectType(typeof(Mutation))]
    public class PassengerMutations
    {
        private readonly IPassengerService _passengerService;

        public PassengerMutations(IPassengerService passengerService)
        {
            this._passengerService = passengerService;
        }

        public async Task<PassengerDTO?> SavePassenger(PassengerDTO passenger)
        {
            return await _passengerService.Save(passenger, passenger.Id);
        }

        public async Task<bool> DeletePassenger(long id)
        {
            return await _passengerService.DeleteById(id);
        }
    }
}