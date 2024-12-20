namespace ticket_store_api.DTOs
{
    public record TransactionDTO(Guid? Id, 
                                 DateTime RegisteredAt, 
                                 string Method, 
                                 decimal Amount, 
                                 string? CardHolderName, 
                                 string? CardNumber, 
                                 short? CardExpirationMonth, 
                                 short? CardExpirationYear, 
                                 short? CVV, 
                                 int? UserCardId);
}