using NHL.Common.DTOs;
using NHL.Database.Contexts;
using NHL.Database.Entities;
using NHL.Database.Interfaces;


namespace NHL.Database.Extensions
{
    public static class NHLContextExtensions
    {
        public static async Task SeedTeamData(this IDbService service)
        {
            try
            {

                await service.AddAsync<Team, TeamDTO>(new TeamDTO{ Name = "Anaheim Ducks", TeamEnum = 24 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Arizona Coyotes", TeamEnum = 53 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Boston Bruins", TeamEnum = 6 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Buffalo Sabres", TeamEnum = 7 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Calgary Flames", TeamEnum = 20 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Carolina Hurricanes", TeamEnum = 12 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Chicago Blackhawks", TeamEnum = 16 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Colorado Avalanche", TeamEnum = 21 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Columbus Blue Jackets", TeamEnum = 29 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Dallas Stars", TeamEnum = 25 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Detroit Red Wings", TeamEnum = 17 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Edmonton Oilers", TeamEnum = 22 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Florida Panthers", TeamEnum = 13 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Los Angeles Kings", TeamEnum = 26 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Minnesota Wild", TeamEnum = 30 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Montreal Canadiens", TeamEnum = 8 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Nashville Predators", TeamEnum = 18 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "New Jersey Devils", TeamEnum = 1 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "New York Islanders", TeamEnum = 2 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "New York Rangers", TeamEnum = 3 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Ottawa Senators", TeamEnum = 9 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Philadelphia Flyers", TeamEnum = 4 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Pittsburgh Penguins", TeamEnum = 5 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "San Jose Sharks", TeamEnum = 28 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Seattle Kraken", TeamEnum = 55 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "St. Louis Blues", TeamEnum = 19 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Tampa Bay Lightning", TeamEnum = 14 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Toronto Maple Leafs", TeamEnum = 10 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Vancouver Canucks", TeamEnum = 23 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Vegas Golden Knights", TeamEnum = 54 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Washington Capitals", TeamEnum = 15 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Winnipeg Jets", TeamEnum = 52 });

                await service.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
