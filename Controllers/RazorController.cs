using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace WebApplicatio2.Controllers
{
    public class RazorController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public string Greet(string id, string name)
        {
            return $"hello {id}{name}";
        }
        public string urlvalues()
        {
            string Pid = Request.QueryString["Pid"];
            string Pname = Request.QueryString["Pname"];
            return $"hello {Pid}{Pname}";
        }

    }
}