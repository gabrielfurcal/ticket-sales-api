using Microsoft.EntityFrameworkCore;
using ticket_store_api.Services;
using ticket_store_api.Services.Contracts;
using ticket_store_api.Services.Implementations;
using ticket_store_api.GraphQL.Schema;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

string? connectionString = configuration.GetConnectionString("connectionString") ?? "";

builder.Services
    .AddAutoMapper(typeof(Program))
    .AddPooledDbContextFactory<TicketSaleDbContext>(o => 
        o.UseMySQL(connectionString)
    )
    .AddGraphQLTypes()
    .AddScoped<ITicketCategoryService, TicketCategoryService>()
    .AddScoped<IPassengerService, PassengerService>()
    .AddScoped<ITicketTypeService, TicketTypeService>()
    .AddScoped<IUserCardService, UserCardService>()
    .AddScoped<ITicketService, TicketService>()
    .Addticket_sales_api().ConfigureHttpClient(c => c.BaseAddress = new Uri("http://localhost:8080/graphql"));

var app = builder.Build();

app.MapGet("/", () => "Ticket Sales API");
app.MapGraphQL();

// using(IServiceScope scope = app.Services.CreateScope())
// {
//     IDbContextFactory<TicketSaleDbContext> contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<TicketSaleDbContext>>();

//     using(TicketSaleDbContext context = contextFactory.CreateDbContext())
//     {
//         context.Database.Migrate();
//     }
// }

app.Run();