using Jasper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nhl.Api;
using Nhl.Api.Models.Player;

namespace NHLStatistics.Controllers
{
    [Route("api/NHLPlayers")]
    public class NHLDataController : ControllerBase
    {
        private readonly INhlApi _NhlApi;
        public NHLDataController(INhlApi playerApi)
        {
            _NhlApi = playerApi;
        }

        // GET: NHLDataController
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllPlayersAsync(CancellationToken cancellationtoken)
        {
             var playerList  = new List<PlayerDataSearchResult>();
            
             var result = await _NhlApi.GetAllPlayersAsync(cancellationtoken);

            for (int i = 0; i < 10; i++)
            { 
                var player = new PlayerDataSearchResult
                {
                    FirstName = result[i].FirstName,
                    LastName = result[i].LastName,
                    Id = result[i].Id,
                    SweaterNumber = result[i].SweaterNumber,
                };
                playerList.Add(player);

            }          

            return Ok(playerList);
        }

    }
   
} 
