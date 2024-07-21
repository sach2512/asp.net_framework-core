using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicatio2.Controllers
{
    public class DemoController : Controller
    {
        public string show()
        {
            return "Helo from home show";
        }
        public string index()
        {
            return "hello from homet index";
        }
    }
}