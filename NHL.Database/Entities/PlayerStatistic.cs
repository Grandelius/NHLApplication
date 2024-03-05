using NHL.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL.Database.Entities
{
    public class PlayerStatistic : IEntity
    {
        public int Id { get; set; }
        public int PlayerID { get; set; }
        public int SeasonID { get; set; }
        public int GamesPlayed { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Pim { get; set; }
        public int PlusMinus { get; set; }
    }
}
