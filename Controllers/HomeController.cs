using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netcore.Models;

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
            var result = new List<dynamic>();
            result.Add( new { Nombre= "Facundo" });
            result.Add( new { Nombre= "Pedro" });
            result.Add( new { Nombre= "Javier" });
            return Json(result);
        }

        [HttpPost]
        public IActionResult Insert(string Nombre)
        {
            // guardar nuevo
            return Json(true);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
