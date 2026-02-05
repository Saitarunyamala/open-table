using Microsoft.AspNetCore.Mvc;

namespace OpenTable.Controllers
{
    
    public class FindATableController : Controller
    {
        [Area("Main")]
        public IActionResult List()
        {
            return Content("Area:Regular, Controller:FindaTable, Action:List");
        }
    }
}