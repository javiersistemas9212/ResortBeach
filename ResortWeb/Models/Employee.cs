using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResortWeb.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [MaxLength(5)]
        public string EmployeeCode { get; set; }

        public User user { get; set; }
    }
}
