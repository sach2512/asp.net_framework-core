using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace WebApplicatio2.Controllers
{
    public class TestController:Controller
    {
        public string show()
        {
            return "Helo from test show";
        }
        public string index()
        {
            return "hello from test index";
        }
    }
}