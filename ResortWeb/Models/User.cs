using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResortWeb.Models
{
    public class User : IdentityUser
    {
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(20)]
        [Required]
        public string Document { get; set; }

        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        [MaxLength(50)]
        [Required]
        public string Country { get; set; }

        [MaxLength(20)]
        public string Gender { get; set; }

    }
}
