using Microsoft.AspNetCore.Mvc;

namespace OpenTable.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/restaurant")]
    public class RestaurantController : Controller
    {
        [Route("list")]
        public IActionResult List()
        {
            return Content("Area:Admin, Controller:Restaurant, Action:List");
        }

        [Route("add")]
        public IActionResult Add()
        {
            return Content("Area:Admin, Controller:Restaurant, Action:Add");
        }

        [Route("update")]
        public IActionResult Update()
        {
            return Content("Area:Admin1, Controller:Restaurant, Action:Update");
        }

        [Route("delete")]
        public IActionResult Delete()
        {
            return Content("Area:Admin1, Controller:Restaurant, Action:Delete");
        }
    }
}