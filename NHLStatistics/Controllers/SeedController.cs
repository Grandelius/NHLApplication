using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NHL.Database.Interfaces;
using NHL.Database.Extensions;

namespace NHLStatistics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController : Controller
    {
        private readonly IDbService _db;
        public SeedController(IDbService db) => _db = db;

        [AllowAnonymous]
        [HttpPost]

        public async Task<IResult> SeedTeamData()
        {
            try
            {
                await _db.SeedTeamData();
                return Results.NoContent();
            }
            catch
            {
                return Results.BadRequest();
            }
        }

    }
}
