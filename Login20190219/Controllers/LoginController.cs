using Login20190219.Models;
using Login20190219.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login20190219.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginViewModel vm)
        {
            LoginModel l = new LoginModel();
            string verify = l.Verify(vm.UserID, vm.Password);
            if(verify == "1")
            {
                return Content("通過");
            }
            else
            {
                return Content("不通過");
            }
        }
        //if
        //switch case
        //for
        //foreach
        //try catch
    }
}