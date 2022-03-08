using ExpenseManagement.API.Infrastracture.Extensions;
using ExpenseManagement.API.Infrastracture.Mappings;
using ExpenseManagement.PersistanceDB.Context;
using ExpenseManagement.Services.Models.Jwt;
using Microsoft.EntityFrameworkCore;

IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json")
                            .Build();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddServices();
builder.Services.RegisterMaps();


builder.Services.Configure<JwtConfiguration>(configuration.GetSection(nameof(JwtConfiguration)));

builder.Services.AddDbContext<ExpenseManagementContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddTokenAuthentication(configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExpenseManagement.API.Infrastracture.Middlewares.ExceptionHandlerMiddleware>();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
