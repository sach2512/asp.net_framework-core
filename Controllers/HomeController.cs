using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicatio2.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult register()
        {
            return View();
        }
        [HttpGet]
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public string login(string txtUid, string txtPwd)
        {
            if (txtUid == "admin" && txtPwd == "admin")
            {
                return $"valid user";
            }
            else
            {
                return $"invalid user";
            }
            //here login and validate method are assocated to each other so in general we keep same name and becuayse of that ambiguity aise
            //and to aboid ambiguity we use method
            //beacuse of these <form action="/home/validate" method="post"> action is not needed
        }

        // in general for everything we retun view view but how to differniatte which view is for twhat 
        // for these puropse we follow a convetnion wher emthod nameand view name are same so when we calll
        // aciion that related view will come 
        //[ActionName(" fgt")] // now we are chaning forgot to fgt so need to chnage all riutes whose name is forgot
        public ActionResult forgot()
        {
            return View("forgotpwd");
        }
        public ActionResult reset()
        {
            return View("resetpswd");
        }
        public ActionResult show(int id)
        {
           if(id == 1)
            {
                return View("show1");
            }
            else
            {
                return View("show2");
            }
        }
    }
}