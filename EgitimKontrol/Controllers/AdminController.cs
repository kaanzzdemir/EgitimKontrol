using Microsoft.AspNetCore.Mvc;

namespace EgitimKontrol.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
