using MvcOurCompanyBLL;
using System.Web.Mvc;

namespace MvcOurCompanyPL.Controllers
{
    public class ReadWriteOrdersController : Controller
    {
        //create a business logic manager
        MvcOurCompanyBLManager blManager = new MvcOurCompanyBLManager();
        
        [Authorize(Users = "two,three")]
        public ActionResult ShowOrders()
        {
            return View(blManager.GetAllOrders());
        }

        [Authorize(Users = "two,three")]
        public ActionResult DetailsOrder(int id)
        {
            return View(blManager.GetOrderById(id));
        }

        [HttpGet]
        [Authorize(Users = "two,three")]
        public ActionResult AddOrder()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Users = "two,three")]
        public ActionResult AddOrder(Order order)
        {
            if (ModelState.IsValid)
            {
                blManager.InsertOrder(order);
                return View("ShowOrders", blManager.GetAllOrders());
            }
            return View();
        }

        [HttpGet]
        [Authorize(Users = "two,three")]
        public ActionResult EditOrder(int id)
        {
            return View(blManager.GetOrderById(id));
        }

        [HttpPost]
        [Authorize(Users = "two,three")]
        public ActionResult EditOrder(Order order)
        {
            if (ModelState.IsValid)
            {
                blManager.UpdateOrder(order);
                return View("ShowOrders", blManager.GetAllOrders());
            }
            return View(order);
        }

        [HttpGet]
        [Authorize(Users = "two,three")]
        public ActionResult DeleteOrder_Get(int id)
        {
            return View(blManager.GetOrderById(id));
        }

        [HttpPost]
        [Authorize(Users = "two,three")]
        public ActionResult DeleteOrder_Post(int id)
        {
            blManager.DeleteOrder(id);
            return View("ShowOrders", blManager.GetAllOrders());
        }
    }
}
