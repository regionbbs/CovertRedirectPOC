﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TokenSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string RedirectUrl)
        {
            return Redirect(RedirectUrl);
        }
    }
}