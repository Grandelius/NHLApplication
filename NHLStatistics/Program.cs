using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Nhl.Api;
using Nhl.Api.Extensions.Microsoft.DependencyInjection;
using Nhl.Api.Models.Player;
using NHL.Common.DTOs;
using NHL.Database.Contexts;
using NHL.Database.Entities;
using NHL.Database.Interfaces;
using NHL.Database.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

ConfigureAutoMapper();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddNhlApi();

builder.Services.AddDbContext<NHLDbContext>(
options => options.UseSqlServer(
 builder.Configuration.GetConnectionString("NHLConnection")));

builder.Services.AddScoped<IDbService, DbService>();


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

void ConfigureAutoMapper()
{
    var config = new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<Team, TeamDTO>().ReverseMap();
    });

    var mapper = config.CreateMapper();
    builder.Services.AddSingleton(mapper);
}
