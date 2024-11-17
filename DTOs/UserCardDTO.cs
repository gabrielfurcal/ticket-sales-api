namespace ticket_store_api.DTOs
{
    public record UserCardDTO(int? Id, string CardHolderName, string CardNumber, short ExpirationMonth, short ExpirationYear, short CVV, int? UserId);
}