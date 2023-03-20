using Microsoft.AspNetCore.Mvc;

namespace EgitimKontrol.Controllers
{
    public class KayitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
