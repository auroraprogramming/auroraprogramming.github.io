using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testmvc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public string Index()
        {
            return "Home";
        }

        public  ViewResult listing()
        {
            ViewBag.lists = new List<string>()
{
    "dddd",
    "hhhh"
};
                        return View();
        }

    }
}
