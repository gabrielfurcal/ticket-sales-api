using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.Schemas.Types;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Schemas.Queries
{
    [ExtendObjectType("Query")]
    public class PassengerQueries
    {
        private readonly IPassengerService _passengerService;
        private readonly IMapper _mapper;

        public PassengerQueries(IPassengerService passengerService, IMapper mapper)
        {
            this._passengerService = passengerService;
            this._mapper = mapper;
        }
        

        public async Task<List<PassengerType>> GetPassengers()
        {
            List<PassengerDTO> dtoPassengers = await _passengerService.FindAll();

            return dtoPassengers.Select(p => _mapper.Map<PassengerDTO, PassengerType>(p)).ToList();
        }

        public async Task<PassengerType?> GetPassengerById(long id)
        {
            PassengerDTO dtoPassenger = await _passengerService.FindById(id);
            return _mapper.Map<PassengerDTO, PassengerType>(dtoPassenger);

        }
    }
}