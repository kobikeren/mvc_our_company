using MvcOurCompanyBLL;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcOurCompanyPL.Controllers
{
    //*******************************************************************
    //****************** Created by kobi keren **************************
    //******************     on 11/07/2017     **************************
    //*******************************************************************

    public class HomeController : Controller
    {
        //create a business logic manager
        MvcOurCompanyBLManager blManager = new MvcOurCompanyBLManager();        

        public ActionResult Index()
        {
            //home page
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.LoginMessage = "Please enter login info";
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginInfo loginInfo)
        {
            if (ModelState.IsValid)
            {
                User user;
                int userId = 0;
                string userDegree = "";

                //check the login info:
                //-----------------------
                //if the login info is not good, 'loginInfoStatus' will contain the
                //string "RejectLoginInfo"
                //-----------------------
                //if the login info is good, 'loginInfoStatus' will contain a string of
                //the following form: "one-5" or "two-26" or "three-14" and so on...
                string loginInfoStatus = blManager.CheckLoginInfo(loginInfo);

                if (loginInfoStatus == "RejectLoginInfo")
                {
                    ViewBag.LoginMessage = "The login info is rejected";
                    return View();
                }

                string[] loginInfoStatusArray = loginInfoStatus.Split(new[] { '-' });
                
                //'userDegree' will contain the string "one", "two" or "three"
                userDegree = loginInfoStatusArray[0];
                userId = int.Parse(loginInfoStatusArray[1]);

                FormsAuthentication.SetAuthCookie(userDegree, false);
                user = blManager.GetUserById(userId);
                Session["FullName"] = user.FirstName + " " + user.LastName;
                Session["UserName"] = user.UserName;

                if (Request["returnurl"] == null)                
                    return RedirectToAction("Index");
                
                return Redirect(Request["returnurl"]);
            }

            ViewBag.LoginMessage = "Please enter login info";
            return View();
        }
    }
}
