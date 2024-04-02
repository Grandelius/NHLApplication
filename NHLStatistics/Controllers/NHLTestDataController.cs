using Jasper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nhl.Api;
using Nhl.Api.Models.Player;

namespace NHLStatistics.Controllers
{
    [Route("api/NHLPlayers")]
    public class NHLTestDataController : ControllerBase
    {
        private readonly INhlApi _NhlApi;
        public NHLTestDataController(INhlApi playerApi)
        {
            _NhlApi = playerApi;
        }

        // GET: NHLDataController
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllActivePlayersAsync(CancellationToken cancellationtoken)
        {
             var playerList  = new List<PlayerDataSearchResult>();

            var activePlayers = new List<PlayerDataSearchResult>();

            
             //var result = await _NhlApi.GetAllPlayersAsync(cancellationtoken);

            var result = await _NhlApi.GetTeamStatisticsBySeasonAsync(55, cancellationtoken);


            await Console.Out.WriteLineAsync("resultat");
            //foreach (var roster in result)
            //{
            //    //if (player.CurrentTeamId != null)
            //    //{
            //    //    activePlayers.Add(player);
            //    //}
            //}



            //for (int i = 0; i < 10; i++)
            //{ 
            //    var player = new PlayerDataSearchResult
            //    {
            //        //FirstName = result[i].FirstName,
            //        //LastName = result[i].LastName,
            //        //Id = result[i].Id,
            //        //SweaterNumber = result[i].SweaterNumber,
            //    };
            //    playerList.Add(player);

            //}          

            return Ok(playerList);
        }

    }
   
} 
