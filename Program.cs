using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.Extensions.Configuration;
using RocketElevatorREST.Models;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

// NOTE: Connect to external MySql server
var myconnection = "Server=codeboxx.cq6zrczewpu2.us-east-1.rds.amazonaws.com;Database=feliciaHartono;UserId=codeboxx;Password=Codeboxx1!";
var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
builder.Services.AddDbContext<feliciaHartonoContext>(opt => 
    opt.UseMySql(myconnection, serverVersion)
        .LogTo(Console.WriteLine)
        .EnableSensitiveDataLogging()
        .EnableDetailedErrors());
        
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

var app = builder.Build();

// app.MapGet("/platforms", () => "Windows,Mac,Linux,Unix");

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
