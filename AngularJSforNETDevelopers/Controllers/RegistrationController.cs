using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularJSforNETDevelopers.Models.Registration;

namespace AngularJSforNETDevelopers.Controllers
{
    public class RegistrationController : Controller
    {
        private RegistarationVmBuilder _registrationVmBuilder = new RegistarationVmBuilder();

        public ActionResult Index()
        {
            return View(_registrationVmBuilder.BuildRegistrationVm());
        }
    }
}