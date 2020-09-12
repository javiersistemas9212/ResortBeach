using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResortWeb.Models
{
    public class Tourist
    {
        public int Id { get; set; }

        public User user { get; set; }
    }
}
