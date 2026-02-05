using Microsoft.AspNetCore.Mvc;

namespace OpenTable.Controllers
{
    
    public class FAQsController : Controller
    {
        [Area("Main")]
        public IActionResult Questions()
        {
            return Content("Area:Regular, Controller:FAQs, Action:Questions");
        }
    }
}