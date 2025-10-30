using DDACAssignment.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Local Connection String 
var connectionString = builder.Configuration.GetConnectionString("PostgresConnection")
        ?? throw new InvalidOperationException("Connection string not found.");

builder.Services.AddDbContext<DDACDbContext>(options =>
    options.UseNpgsql(connectionString));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/", () => "You are watching the greatest API in the world: DDAC");
app.Run();

// TODO: nit - Recheck the Context lambda initial e.g m => m.MatchId
// TODO: nit - Recheck the variable name for List e.g Tournament instead of Tournaments
// TODO: Add constraints
// TODO: Separate HTTP methods into it rightful controller
