using Nhl.Api;
using Nhl.Api.Extensions.Microsoft.DependencyInjection;
using Nhl.Api.Models.Player;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddNhlApi();
//builder.Services.AddTransient<PlayerDataSearchResult>();
//builder.Services.AddSingleton<INhlPlayerApi, NhlPlayerApi>();
//builder.Services.AddSingleton<INhlLeagueApi, NhlLeagueApi>();
//builder.Services.AddSingleton<INhlStatisticsApi, NhlStatisticsApi>();

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
