using Microsoft.EntityFrameworkCore;
using ticket_store_api.Services;
using ticket_store_api.Services.Contracts;
using ticket_store_api.Services.Implementations;
using ticket_store_api.Schemas;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

string? connectionString = configuration.GetConnectionString("connectionString") ?? "";

builder.Services
    .AddAutoMapper(typeof(Program))
    .AddPooledDbContextFactory<TicketSaleDbContext>(o => 
        o.UseMySQL(connectionString)
    )
    .AddScoped<ITicketCategoryService, TicketCategoryService>()
    .AddScoped<IPassengerService, PassengerService>()
    .AddScoped<ITicketTypeService, TicketTypeService>()
    .AddScoped<IUserCardService, UserCardService>()
    .AddGraphQLTypes();


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