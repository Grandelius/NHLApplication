using Microsoft.EntityFrameworkCore;
using Nhl.Api;
using Nhl.Api.Extensions.Microsoft.DependencyInjection;
using Nhl.Api.Models.Player;
using NHL.Database.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddNhlApi();

builder.Services.AddDbContext<NHLDbContext>(
options => options.UseSqlServer(
 builder.Configuration.GetConnectionString("NHLConnection")));


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

app.Run();
