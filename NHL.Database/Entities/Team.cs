﻿using NHL.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL.Database.Entities
{
    internal class Team : IEntity
    {
        public int Id { get; set; }
    }
}
