﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Net_FrameworkMVC_Week5.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [ActionName("update")]
        public ActionResult edit()
        {
            return View("pccfpi");
        }
        public ActionResult Index()
        {
            return View();
        }

    }
}