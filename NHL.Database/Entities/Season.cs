using NHL.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL.Database.Entities
{
    public class Season : IEntity
    {
        public int Id { get; set; }
        public int SeasonYear { get; set; }
    }
}
