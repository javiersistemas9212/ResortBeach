using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResortWeb.Data;
using ResortWeb.Models;

namespace ResortWeb.Controllers
{
    public class ReserveController : Controller
    {
        private readonly DataContext _dataContext;

        public ReserveController(
                DataContext dataContext
        )
        {
            _dataContext = dataContext;

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ListReserve(string type)
        {

            List<typeViewModel> lista = new List<typeViewModel>();


            if (type == "h"){
                var listah = await _dataContext.Rooms.ToListAsync();

                foreach (var item in listah)
                {
                    lista.Add(new typeViewModel { Id=item.Id, Type= "h", PriceXDay=item.PriceXDay });
                }

            }else{ 
                var listac = await _dataContext.Cabins.ToListAsync();
                foreach (var item in listac)
                {
                    lista.Add(new typeViewModel { Id = item.Id, Type = "c", PriceXDay = item.PriceXDay });
                }

            }
               
            return View(lista);
        }


    }
}