using ticket_store_api.DTOs;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Schemas.Queries
{
    [ExtendObjectType(typeof(Query))]
    public class PassengerQueries
    {
        private readonly IPassengerService _passengerService;

        public PassengerQueries(IPassengerService passengerService)
        {
            this._passengerService = passengerService;
        }
        

        public async Task<List<PassengerDTO>> GetPassengers()
        {
            return await _passengerService.FindAll();
        }

        public async Task<PassengerDTO?> GetPassengerById(long id)
        {
            return await _passengerService.FindById(id);

        }
    }
}