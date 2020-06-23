using Microsoft.AspNetCore.Mvc;

namespace Practica2.Controllers
{
    public class VentaController :Controller
    {
            public IActionResult Index()
            {
                return View();
            }
            public IActionResult Destacados()
            {
                return View();
            }
            public IActionResult Catalogo()
            {
                return View();
            }
            public IActionResult Servicios()
            {
                return View();
            }
    } 
}