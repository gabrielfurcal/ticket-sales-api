using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.Schemas.Types
{
    [GraphQLName("Transaction")]
    public class TransactionType
    {
        public Guid Id { get; set; }
        public DateTime RegisteredAt { get; set; }
        public required string Method { get; set; }
        public decimal Amount { get; set; }
        public required string CardNumber { get; set; }
        public short CardExpirationMonth { get; set; }
        public short CardExpirationYear { get; set; }
        public short CVV { get; set; }

        [GraphQLIgnore]
        public int UserCardId { get; set; }

        public async Task<UserCardType> UserCard([Service] IUserCardService _userCardService, IMapper _mapper)
        {
            UserCardDTO dtoUserCard = await _userCardService.FindById(this.UserCardId);
            return _mapper.Map<UserCardDTO, UserCardType>(dtoUserCard);
        }
    }
}