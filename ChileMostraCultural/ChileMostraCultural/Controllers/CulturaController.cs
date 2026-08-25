using Microsoft.AspNetCore.Mvc;

namespace ChileMostraCultural.Controllers
{
    public class CulturaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
