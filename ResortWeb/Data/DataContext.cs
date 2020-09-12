using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ResortWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResortWeb.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Tourist> Tourists { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Cabin> Cabins { get; set; }
        public DbSet<ResortWeb.Models.AddUserViewModel> AddUserViewModel { get; set; }
        public DbSet<Reserve> Reserves { get; set; }
        public DbSet<ResortWeb.Models.EditUserViewModel> EditUserViewModel { get; set; }
     

    }
}
