using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.Schemas.Types;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Schemas.Mutations
{
    [ExtendObjectType(nameof(BaseMutations))]
    public class PassengerMutations
    {
        private readonly IPassengerService _passengerService;
        private readonly IMapper _mapper;

        public PassengerMutations(IPassengerService passengerService, IMapper mapper)
        {
            this._passengerService = passengerService;
            this._mapper = mapper;
        }

        public async Task<PassengerType?> SavePassenger(PassengerInputType passenger)
        {
            PassengerDTO dtoPassenger = await _passengerService.Save(_mapper.Map<PassengerInputType, PassengerDTO>(passenger), passenger.Id);
            return _mapper.Map<PassengerDTO, PassengerType>(dtoPassenger);
        }

        public async Task<bool> DeletePassenger(long id) 
        {
            return await _passengerService.DeleteById(id);
        }
    }
}