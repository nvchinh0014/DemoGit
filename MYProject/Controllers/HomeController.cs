﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MYProject.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
	    
            int i;
            int j;
            int x = 29;
            i = 50;
            j = 90;
            Add(i,j);
            return View();
        }
	
	private int Add(int a,int b)
	{
	    return a+b;
	}

    }
}
