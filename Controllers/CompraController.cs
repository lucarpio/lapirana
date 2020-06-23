using Microsoft.AspNetCore.Mvc;

namespace lapirana.Controllers
{
    public class CompraController
    {
        public class Compra : Controller
        {
            public IActionResult Index()
            {
                return View();
            }
        }
    }
}