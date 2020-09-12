using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResortWeb.Models
{
    public class Room
    {
        public int Id { get; set; }

        [MaxLength(20)]
        public string PriceXDay { get; set; }

        [MaxLength(2)]
        public string TypeRoom { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }

        public Boolean Available { get; set; }
    }
}
