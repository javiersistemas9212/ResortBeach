using ResortWeb.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResortWeb.Data
{
    public class seedDB
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        public seedDB(
            DataContext context,
            IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckRoles();
            //await CheckRoomsAsync();
        }

        private async Task CheckRoles()
        {
            await _userHelper.CheckRoleAsync("turista");
            await _userHelper.CheckRoleAsync("empleado");
        }

        private async Task CheckRoomsAsync()
        {
                AddRoom("150.000", "Doble", "Prueba", true);
                await _context.SaveChangesAsync();
            
        }

        private void AddRoom(string PriceXDay, string TypeRoom, string Description, Boolean Available)
        {
            _context.Rooms.Add(new Models.Room
            {
                PriceXDay = PriceXDay,
                Available = Available,
                Description = Description,
                TypeRoom = TypeRoom
            });
        }
    }
}

