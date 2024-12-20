using AutoMapper;
using ticket_store_api.DTOs;
using ticket_store_api.GraphQL.External.Types;
using ticket_store_api.Services.Contracts;

namespace ticket_store_api.GraphQL.Schema.Types
{
    [GraphQLName("Ticket")]
    public class TicketType
    {
        public Guid Id { get; set; }
        public required string Seat { get; set; }
        public bool Checked { get; set; }

        [GraphQLIgnore]
        public required long PassengerId { get; set; }

        public async Task<PassengerType> Passenger([Service] IPassengerService _passengerService, [Service] IMapper _mapper)
        {
            PassengerDTO dtoPassenger = await _passengerService.FindById(this.PassengerId);
            return _mapper.Map<PassengerDTO, PassengerType>(dtoPassenger);
        }

        [GraphQLIgnore]
        public int TicketTypeId { get; set; }

        public async Task<TicketTypeType> GetTicketType([Service] ITicketTypeService _ticketTypeService, [Service] IMapper _mapper)
        {
            TicketTypeDTO dtoTicketType = await _ticketTypeService.FindById(this.TicketTypeId);
            return _mapper.Map<TicketTypeDTO, TicketTypeType>(dtoTicketType);
        }

        [GraphQLIgnore]
        public int TicketCategoryId { get; set; }

        public async Task<TicketCategoryType> TicketCategory([Service] ITicketCategoryService _ticketCategoryService, [Service] IMapper _mapper)
        {
            TicketCategoryDTO dtoTicketCategory = await _ticketCategoryService.FindById(this.TicketCategoryId);
            return _mapper.Map<TicketCategoryDTO, TicketCategoryType>(dtoTicketCategory);
        }

        [GraphQLIgnore]
        public Guid TransactionId { get; set; }

        public async Task<TransactionType> Transaction([Service] ITransactionService _transactionService, [Service] IMapper _mapper)
        {
            TransactionDTO dtoTransaction = await _transactionService.FindById(this.TransactionId);
            return _mapper.Map<TransactionDTO, TransactionType>(dtoTransaction);
        }        

        [GraphQLIgnore]
        public required int ScheduleId { get; set; }

        public async Task<ScheduleType> Schedule([Service] GetScheduleByIdQuery query, [Service] IMapper _mapper)
        {
            var result = await query.ExecuteAsync(this.ScheduleId);
            var schedule = result.Data?.ScheduleById!;
            var scheduleType = _mapper.Map<IGetScheduleById_ScheduleById, ScheduleType>(schedule);

            return scheduleType;
        }
    }
}