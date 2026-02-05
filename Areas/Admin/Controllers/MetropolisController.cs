using Microsoft.AspNetCore.Mvc;

namespace OpenTable.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/metropolis")]
    public class MetropolisController : Controller
    {
        [Route("list")]
        public IActionResult List()
        {
            return Content("Area:Admin, Controller:1Metropolis, Action:List");
        }

        [Route("add")]
        public IActionResult Add()
        {
            return Content("Area:Admin, Controller:Metropolis, Action:Add");
        }

        [Route("update")]
        public IActionResult Update()
        {
            return Content("Area:Admin, Controller:Metropolis, Action:Update");
        }

        [Route("delete")]
        public IActionResult Delete()
        {
            return Content("Area:Admin1, Controller:Metropolis, Action:Delete");
        }
    }
}