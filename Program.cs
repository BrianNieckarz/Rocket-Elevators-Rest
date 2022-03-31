using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.Extensions.Configuration;
using RocketElevatorREST.Models;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

// NOTE: Connect to external MySql server
var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
builder.Services.AddDbContext<feliciaHartonoContext>(opt => 
    opt.UseMySql(builder.Configuration.GetConnectionString("foobarDB"), serverVersion)
        .LogTo(Console.WriteLine)
        .EnableSensitiveDataLogging()
        .EnableDetailedErrors());
        
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    // app.UseSwagger();
    // app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();