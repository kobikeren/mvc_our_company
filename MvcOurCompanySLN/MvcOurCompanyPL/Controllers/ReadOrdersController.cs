using MvcOurCompanyBLL;
using System.Web.Mvc;

namespace MvcOurCompanyPL.Controllers
{
    public class ReadOrdersController : Controller
    {
        //create a business logic manager
        MvcOurCompanyBLManager blManager = new MvcOurCompanyBLManager();
        
        [Authorize(Users = "one,two,three")]
        public ActionResult ShowOrders()
        {
            return View(blManager.GetAllOrders());
        }

        [Authorize(Users = "one,two,three")]
        public ActionResult DetailsOrder(int id)
        {
            return View(blManager.GetOrderById(id));
        }
    }
}
