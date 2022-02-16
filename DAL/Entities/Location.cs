﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string CityCode { get; set; }
    }
}
