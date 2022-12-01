using Microsoft.AspNetCore.Mvc;

namespace WebMVCCore.Controllers
{
    public class FacturasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Devolver()
        {

            return View();
        }


    }
}
