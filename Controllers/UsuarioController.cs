using Microsoft.AspNetCore.Mvc;

namespace lapirana.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IniciarSesion()
        {
            return View();
        }
        public IActionResult Registro()
        {
            return View();
        }
        public IActionResult Actualizar()
        {
            return View();
        }
    }
}