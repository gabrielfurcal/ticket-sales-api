using HotChocolate.Execution.Configuration;
using ticket_store_api.Schemas.Mutations;
using ticket_store_api.Schemas.Queries;

namespace ticket_store_api.Schemas
{
    public static class GraphQLServiceExtensions
    {
        public static IServiceCollection AddGraphQLTypes(this IServiceCollection services)
        {
            var setup = services
                .AddGraphQLServer()
                // .ModifyOptions(options =>
                // {
                //     options.DefaultBindingBehavior = BindingBehavior.Explicit;
                // })
                .AddDocumentFromFile(@"./Schemas/schema.graphql");

            //Queries
            setup = setup
                .AddQueryType<BaseQueries>()        
                .AddTypeExtension<TicketCategoryQueries>()
                .AddTypeExtension<PassengerQueries>()
                .AddTypeExtension<TicketTypeQueries>()
                .AddTypeExtension<UserCardQueries>()
                .AddTypeExtension<TransactionQueries>()
                .AddTypeExtension<TicketQueries>();

            //Mutations
            setup = setup
                .AddMutationType<BaseMutations>()
                .AddTypeExtension<TicketCategoryMutations>()
                .AddTypeExtension<PassengerMutations>()
                .AddTypeExtension<TicketTypeMutations>()
                .AddTypeExtension<UserCardMutations>()
                .AddTypeExtension<TransactionMutations>()
                .AddTypeExtension<TicketMutations>();

            return setup.Services;
        }
    }
}