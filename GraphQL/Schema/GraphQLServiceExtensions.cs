using HotChocolate.Execution.Configuration;
using ticket_store_api.GraphQL.Schema.Mutations;
using ticket_store_api.GraphQL.Schema.Queries;

namespace ticket_store_api.GraphQL.Schema
{
    public static class GraphQLServiceExtensions
    {
        public static IServiceCollection AddGraphQLTypes(this IServiceCollection services)
        {
            var setup = services
                .AddGraphQLServer();
                // .AddDocumentFromFile(@"./Schemas/schema.graphql");

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