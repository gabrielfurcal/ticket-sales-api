using Microsoft.EntityFrameworkCore;
using ticket_store_api.Schemas.Mutations;
using ticket_store_api.Schemas.Queries;
using ticket_store_api.Services;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

string? connectionString = configuration.GetConnectionString("connectionString");

builder.Services
    .AddPooledDbContextFactory<TicketSaleDbContext>(o => 
        o.UseSqlite(connectionString)
    )
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGraphQL();

using(IServiceScope scope = app.Services.CreateScope())
{
    IDbContextFactory<TicketSaleDbContext> contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<TicketSaleDbContext>>();

    using(TicketSaleDbContext context = contextFactory.CreateDbContext())
    {
        context.Database.Migrate();
    }
}

app.Run();