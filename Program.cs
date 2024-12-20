using Microsoft.EntityFrameworkCore;
using ticket_store_api.Services;
using ticket_store_api.Services.Contracts;
using ticket_store_api.Services.Implementations;
using ticket_store_api.GraphQL.Schema;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

string? connectionString = configuration.GetConnectionString("connectionString") ?? "";
string? adminInputsApiGraphQLUrl = configuration["Environments:AdminInputsApiGraphQLUrl"];

builder.Services
    .AddAutoMapper(typeof(Program))
    .AddPooledDbContextFactory<TicketSaleDbContext>(o => 
        o.UseMySQL(connectionString)
    )
    .AddScoped<ITicketCategoryService, TicketCategoryService>()
    .AddScoped<IPassengerService, PassengerService>()
    .AddScoped<ITicketTypeService, TicketTypeService>()
    .AddScoped<IUserCardService, UserCardService>()
    .AddScoped<ITicketService, TicketService>()
    .AddGraphQLTypes()
    .Addticket_sales_api().ConfigureHttpClient(c => c.BaseAddress = new Uri(adminInputsApiGraphQLUrl!));

var app = builder.Build();

app.MapGet("/", () => "Ticket Sales API");
app.MapGraphQL();

#region Initial Migrate Database
// using(IServiceScope scope = app.Services.CreateScope())
// {
//     IDbContextFactory<TicketSaleDbContext> contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<TicketSaleDbContext>>();

//     using(TicketSaleDbContext context = contextFactory.CreateDbContext())
//     {
//         context.Database.Migrate();
//     }
// }
#endregion

app.Run();