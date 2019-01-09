﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Task7.Entities
{
    public class Award
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public override string ToString()
        {
            return $"{Id} {Title}";
        }
    }
}
