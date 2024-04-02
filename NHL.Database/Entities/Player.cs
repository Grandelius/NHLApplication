using NHL.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL.Database.Entities
{
    public class Player : IEntity
    {
        public Player()
        {
            Statistics = new HashSet<PlayerStatistic>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string? BirthPlace { get; set; }
        public string? HeadShotImage { get; set; }
        public string? Shoots { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public int PlayerEnum { get; set; }

        public virtual ICollection<PlayerStatistic>? Statistics { get; set; }
        public virtual ICollection<PlayerTeam>? PlayerTeams { get; set; }
    }
}
