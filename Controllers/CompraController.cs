using Microsoft.AspNetCore.Mvc;

namespace lapirana.Controllers
{
    public class CompraController : Controller
    {
            public IActionResult Index()
            {
                return View();
            }
    }
}