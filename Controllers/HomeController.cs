using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netcore.Models;
using netcore.DAO;

namespace netcore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            demonetcoreContext ctx = new demonetcoreContext();
            var result = ctx.Usuario.Select(u => new { Nombre = u.Nombre});
            return Json(result);
        }

        [HttpPost]
        public IActionResult Insert(string Nombre)
        {
            demonetcoreContext ctx = new demonetcoreContext();
            ctx.Usuario.Add(new Usuario {
                Nombre = Nombre
            });
            ctx.SaveChanges();
            return Json(true);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
