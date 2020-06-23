using Microsoft.AspNetCore.Mvc;

namespace lapirana.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}