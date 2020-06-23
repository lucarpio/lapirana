using Microsoft.AspNetCore.Mvc;

namespace lapirana.Controllers
{
    public class UsuarioController
    {
        public class Usuario : Controller
        {
            public IActionResult Index()
            {
                return View();
            }
        }
    }
}