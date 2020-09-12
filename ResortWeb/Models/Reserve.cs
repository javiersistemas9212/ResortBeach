using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResortWeb.Models
{
    public class Reserve
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public int TypeId { get; set; }

        public Tourist tourist { get; set; }
    }
}
