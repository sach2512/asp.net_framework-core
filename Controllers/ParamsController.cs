using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicatio2.Controllers
{

    public class ParamsController : Controller
    {
        //this is our routes design here id is optional 
        //    routes.MapRoute(
        // name: "Default",
        // url: "{controller}/{action}/{id}",
        //defaults: new { controller = "Test", action = "Index", id = UrlParameter.Optional
        //}
        //);
        public string index1(int id)
        {
            return Convert.ToString(id);
            //here we are making id in mandatory in method since here it is mandatory we need to pass it pakka in routes
        }
        //now if we want to make it optinal we have two options 
        public string index2(int id = 0) //option 1 
        {
            return Convert.ToString(id);

        }
        public string index3(int? id) //option 2
        {
            return Convert.ToString(id);

        }
        public string index4(int x)  // these will give error bcoz paramtere names are missmatching
        {
            return Convert.ToString(x);

        }
        public string index5(int? x)  // these will not give error either value bcoz paramtere names are missmatching
        {
            return Convert.ToString(x);

        }
        public string index6(string id)  // these is completly valid and by default stribg is nullable so no need optinal chainig
        {
            return Convert.ToString(id);//here it aceepts all values except double type

        }
        //passing multiple paramteres to url 

        public string index7(string id, int age)
        {
            int a = Convert.ToInt32(age);
            return ($"hello {id} age is ,{a} "); // here both are required fields

        }
        public string index8(string id, int? age)
        {
            // routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}/{age}",
            //    defaults: new { controller = "Test", action = "Index", id = UrlParameter.Optional, age = UrlParameter.Optional }
            //); chnaging route config so as it canaceept two values
            int a = Convert.ToInt32(age);
            return ($"hello {id} age is ,{a} "); // here both are required fields and order also matter 

        }
        public string index9(int? pid, string pname, double? price)
        {
            return ($"{pid} ,{pname},{price}"); //here used question mark soo all are optinal 
        }
        public string index10()
        {

            // collecting values of url 
            string Pid = Request.QueryString["Pid"];
            string Pname = Request.QueryString["Pname"];
            string Price = Request.QueryString["Price"];
            return ($"hello {Pid} {Pname} {Price}");
        }
        public void validitate1()
        {
            string name = Request.QueryString["name"];
            string password = Request.QueryString["password"];
            if (name == "sachin" && password == "abc")
            {
                string details = ($"{name},{password}");
                Console.WriteLine(details);
            }


        }
        public void validate2(string name, string password)
        {
            // these is a another method to get data from url //latest instaed of req.querystring

        }
        internal string Test(int id)
        {
            return $"hello {id}";

        } // even if we do /params/test we cant see out put becuae
          // itss scope is internal for a controller the scope should be public bydefault
          //nevr do overloading of actionmethods  and method cannot be static because instance is created interanlly 
          // if we want to define any non action method dnt make them public 

        //if we want to do that we need to use ActionMethod  for examole

        [ActionName("show1")]
        public string Show1()
        {
            return "Hello";
        }

        [ActionName("show2")]
        public string Show2()
        {
            return "Hello";
        }




    }
}