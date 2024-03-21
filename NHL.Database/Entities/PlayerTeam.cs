using NHL.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL.Database.Entities
{
    public class PlayerTeam : IReferenceEntity
    {
        public int PlayerId { get; set; }
        public int TeamId { get; set; }
        public int SeasonId { get; set; }
        public Player Player { get; set; }
        public Team Team { get; set; }
        public Season Season { get; set; }

    }
}
