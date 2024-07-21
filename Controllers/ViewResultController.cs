using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicatio2.Controllers
{
    public class ViewResultController : Controller
    {

        public ViewResult index() 
        { 
            // generall we need to crrate instance of viewresult to return it a sresult becuase ethod is not statci
            ViewResult result = new ViewResult();
            return result;
            // but we got helper function which canbe dritcly returned without cratng instance
        }
        public ActionResult Index()
        {
            return View(); // view is helper function nd there are manay of thes ekind 
        }
    }
}