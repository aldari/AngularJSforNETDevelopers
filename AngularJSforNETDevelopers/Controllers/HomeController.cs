﻿using System.Web.Mvc;

namespace AngularJSforNETDevelopers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index", "", "you");
        }
    }
}