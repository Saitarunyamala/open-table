using Microsoft.AspNetCore.Mvc;

namespace OpenTable.Areas.Main.Controllers  
{
    public class HomeController : Controller
    {
        [Area("Main")] 
        public IActionResult Index()
        {
            return View(); // ✅ Test response
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult PrivacyPolicy()
        {
            return View();
        }
    }
}