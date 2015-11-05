using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularJSforNETDevelopers.Models.Registration;

namespace AngularJSforNETDevelopers.Controllers
{
    public class InstructorsController : Controller
    {
        private readonly RegistarationVmBuilder _registarationVmBuilder = new RegistarationVmBuilder();

        // GET: Instructors
        public ActionResult Index()
        {
            return View("Index", "", _registarationVmBuilder.GetSerializeInstructors());
        }
    }
}