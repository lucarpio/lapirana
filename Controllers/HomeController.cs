using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using lapirana.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practica2.Models;

namespace Practica2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult QuienesSomos()
        {
            return View();
        }
        
        public IActionResult ServiciosProductos()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }

        public IActionResult ContactoCreate(Contacto objContacto)
        {
            objContacto.alerta = "Hola " + objContacto.nombre +" "+ objContacto.apellido + " su mensaje ha sido enviado con exito";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
