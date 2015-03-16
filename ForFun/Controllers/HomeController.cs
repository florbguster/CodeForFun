using CodeForFun.Models;
using CodeForFun.Tasks;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CodeForFun.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult BoxGame()
        {
            return View();
        }

        public ActionResult CarRegistry()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SaveCarList( IEnumerable<CarModel> cars )
        {
            IInventoryTasks InventoryTasks = new InventoryTasks();
            var isSaved = InventoryTasks.SaveCars( cars );

            if (isSaved)
            {
                return Json( new { result = "Save Successful" } );
            }
            else
            {
                return Json( new { result = "Save Failed." } );
            }
        }
    }
}