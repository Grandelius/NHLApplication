using NHL.Common.DTOs;
using NHL.Database.Contexts;
using NHL.Database.Entities;
using NHL.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL.Database.Extensions
{
    public static class NHLContextExtensions
    {
        public static async Task SeedteamData(this IDbService service)
        {
            try
            {
                await service.AddAsync<Team, TeamDTO>(new TeamDTO{ Name = "Anaheim Ducks", Id = 24 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Arizona Coyotes", Id = 53 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Boston Bruins", Id = 6 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Buffalo Sabres", Id = 7 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Calgary Flames", Id = 20 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Carolina Hurricanes", Id = 12 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Chicago Blackhawks", Id = 16 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Colorado Avalanche", Id = 21 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Columbus Blue Jackets", Id = 29 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Dallas Stars", Id = 25 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Detroit Red Wings", Id = 17 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Edmonton Oilers", Id = 22 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Florida Panthers", Id = 13 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Los Angeles Kings", Id = 26 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Minnesota Wild", Id = 30 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Montreal Canadiens", Id = 8 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Nashville Predators", Id = 18 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "New Jersey Devils", Id = 1 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "New York Islanders", Id = 2 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "New York Rangers", Id = 3 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Ottawa Senators", Id = 9 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Philadelphia Flyers", Id = 4 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Pittsburgh Penguins", Id = 5 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "San Jose Sharks", Id = 28 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Seattle Kraken", Id = 55 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "St. Louis Blues", Id = 19 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Tampa Bay Lightning", Id = 14 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Toronto Maple Leafs", Id = 10 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Vancouver Canucks", Id = 23 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Vegas Golden Knights", Id = 54 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Washington Capitals", Id = 15 });
                await service.AddAsync<Team, TeamDTO>(new TeamDTO { Name = "Winnipeg Jets", Id = 52 });

                await service.SaveChangesAsync();

               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
