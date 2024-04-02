using NHL.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL.Database.Entities
{
    public class Team : IEntity
    {
        public Team()
        {
            Statistics = new HashSet<TeamStatistic>();
            PlayerTeams = new HashSet<PlayerTeam>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Logo { get; set; }
        public int TeamEnum { get; set; }

        public virtual ICollection<TeamStatistic> Statistics { get; set; }
        public virtual ICollection<PlayerTeam> PlayerTeams { get; set; }
    }
}
