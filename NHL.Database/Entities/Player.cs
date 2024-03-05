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
        public int Id { get; set; }
    }
}
