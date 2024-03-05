using NHL.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL.Database.Entities
{
    public class TeamStatistic : IEntity
    {
        public int Id { get; set; }
        public int GamesPlayed { get; set; }
        public int Points { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
    }
}
