using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Core.Models
{
    public class Menu
    {
        public int Id { get; set; }

        public string Name { get; set; }
        //FK
        public int RestaurantId { get; set; }
        
        //navigation property
        public Restaurant Restaurant { get; set; }
    }
}
