﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Semplice.Kiriwa.WebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: App/Index
        public ActionResult Index()
        {
            return Redirect("~/App/Index");
        }
    }
}