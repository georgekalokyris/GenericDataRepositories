﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TotalCases : IEntity
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int EntityId { get; set; }
    }
}
