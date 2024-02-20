using Newtonsoft.Json;

namespace NHLStatistics.Domain
{
    public class PlayerDataSearchResult
    {
        //
        // Summary:
        //     The unique identifier for the NHL player
        //     Example: 8478402 - Connor McDavid
        [JsonProperty("id")]
        public int Id { get; set; }

        //
        // Summary:
        //     The current team identifier for the NHL player
        //     Example: 14 - Tampa Bay Lightning
        [JsonProperty("currentTeamId")]
        public int? CurrentTeamId { get; set; }

        //
        // Summary:
        //     The first name of the NHL player
        //     Example: Connor
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        //
        // Summary:
        //     The full name of the NHL player
        //     Example: Connor McDavid
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        //
        // Summary:
        //     The last name of the NHL player
        //     Example: McDavid
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        //
        // Summary:
        //     The position code of the NHL player
        //     Excample: C - Center
        [JsonProperty("positionCode")]
        public string PositionCode { get; set; }

        //
        // Summary:
        //     The sweater number of the NHL player
        //     Example: 97 - Connor McDavid
        [JsonProperty("sweaterNumber")]
        public int? SweaterNumber { get; set; }
    }

}
