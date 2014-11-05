using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MYProject.Controllers
{
    public class AboutController : Controller
    {
        //
        // GET: /About/

        public ActionResult Index()
        {
            int x;
            string s = string.Empty;
            int y;

            x = 20;
            y = 30;

            return View();
        }

    }
}
