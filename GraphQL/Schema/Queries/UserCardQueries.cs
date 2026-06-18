using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.GraphQL.Schema.Types;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.GraphQL.Schema.Queries
{
    [ExtendObjectType(nameof(BaseQueries))]
    public class UserCardQueries
    {
        private readonly IUserCardService _userCardService;
        private readonly IMapper _mapper;

        public UserCardQueries(IUserCardService userCardService, IMapper mapper)
        {
            this._userCardService = userCardService;
            this._mapper = mapper;
        }
        
        public async Task<List<UserCardType>> GetUserCards()
        {
            List<UserCardDTO> dtoUserCards = await _userCardService.FindAll();
            return dtoUserCards.Select(uc => _mapper.Map<UserCardDTO, UserCardType>(uc)).ToList();
        }

        public async Task<UserCardType?> GetUserCardById(int id)
        {
            UserCardDTO dtoUserCard = await _userCardService.FindById(id);
            return _mapper.Map<UserCardDTO, UserCardType>(dtoUserCard);
        }
    }
}