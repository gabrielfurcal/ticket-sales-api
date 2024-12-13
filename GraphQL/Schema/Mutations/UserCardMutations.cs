using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.GraphQL.Schema.InputTypes;
using ticket_store_api.GraphQL.Schema.Types;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.GraphQL.Schema.Mutations
{
    [ExtendObjectType(nameof(BaseMutations))]
    public class UserCardMutations
    {
        private readonly IUserCardService _userCardService;
        private readonly IMapper _mapper;

        public UserCardMutations(IUserCardService userCardService, IMapper mapper)
        {
            this._userCardService = userCardService;
            this._mapper = mapper;
        }

        public async Task<UserCardType?> SaveUserCard(UserCardInputType userCard)
        {
            UserCardDTO dtoUserCard = await _userCardService.Save(_mapper.Map<UserCardInputType, UserCardDTO>(userCard), userCard.Id);
            return _mapper.Map<UserCardDTO, UserCardType>(dtoUserCard);
        }

        public async Task<bool> DeleteUserCard(int id)
        {
            return await _userCardService.DeleteById(id);
        }
    }
}