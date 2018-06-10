﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Core.Models
{
    public class Item
    {
        public int Id { get; set; }
        //FK
        public int MenuId { get; set; }

        public Menu Menu { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}