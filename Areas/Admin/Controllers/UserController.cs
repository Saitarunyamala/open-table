using Microsoft.AspNetCore.Mvc;

namespace OpenTable.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/user")]
    public class UserController : Controller
    {
        [Route("list")]
        public IActionResult List()
        {
            return Content("Area:Admin, Controller:User, Action:List");
        }

        [Route("add")]
        public IActionResult Add()
        {
            return Content("Area:Admin, Controller:User, Action:Add");
        }

        [Route("update")]
        public IActionResult Update()
        {
            return Content("Area:Admin1, Controller:User, Action:Update");
        }

        [Route("delete")]
        public IActionResult Delete()
        {
            return Content("Area:Admin1, Controller:User, Action:Delete");
        }
    }
}