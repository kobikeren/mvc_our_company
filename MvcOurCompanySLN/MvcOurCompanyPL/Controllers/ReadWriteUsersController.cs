using MvcOurCompanyBLL;
using System.Web.Mvc;

namespace MvcOurCompanyPL.Controllers
{
    public class ReadWriteUsersController : Controller
    {
        //create a business logic manager
        MvcOurCompanyBLManager blManager = new MvcOurCompanyBLManager();
        
        [Authorize(Users = "three")]
        public ActionResult ShowUsers()
        {
            return View(blManager.GetAllUsers());
        }

        [Authorize(Users = "three")]
        public ActionResult DetailsUser(int id)
        {
            return View(blManager.GetUserById(id));
        }

        [HttpGet]
        [Authorize(Users = "three")]
        public ActionResult AddUser()
        {
            ViewBag.AddUserMessage = "Please enter user details";
            return View();
        }

        [HttpPost]
        [Authorize(Users = "three")]
        public ActionResult AddUser(User user)
        {
            if (ModelState.IsValid)
            {
                if (blManager.UserNameExists(user.UserName))
                {
                    ViewBag.AddUserMessage = 
                        "This user name is not available. please enter a different username";
                    return View();
                }
                blManager.InsertUser(user);
                return View("ShowUsers", blManager.GetAllUsers());
            }
            ViewBag.AddUserMessage = "Please enter user details";
            return View();
        }

        [HttpGet]
        [Authorize(Users = "three")]
        public ActionResult EditUser(int id)
        {
            return View(blManager.GetUserById(id));
        }

        [HttpPost]
        [Authorize(Users = "three")]
        public ActionResult EditUser(User user)
        {
            if (ModelState.IsValid)
            {
                blManager.UpdateUser(user);
                return View("ShowUsers", blManager.GetAllUsers());
            }
            return View(user);
        }

        [HttpGet]
        [Authorize(Users = "three")]
        public ActionResult DeleteUser_Get(int id)
        {
            return View(blManager.GetUserById(id));
        }

        [HttpPost]
        [Authorize(Users = "three")]
        public ActionResult DeleteUser_Post(int id)
        {
            blManager.DeleteUser(id);
            return View("ShowUsers", blManager.GetAllUsers());
        }
    }
}
