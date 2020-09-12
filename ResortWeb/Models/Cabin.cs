using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResortWeb.Models
{
    public class Cabin
    {
        public int Id { get; set; }

        [MaxLength(20)]
        public string PriceXDay { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }

        public Boolean Available { get; set; }

    }
}
