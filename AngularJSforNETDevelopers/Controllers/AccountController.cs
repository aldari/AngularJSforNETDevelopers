using System.Net;
using System.Web.Mvc;
using AngularJSforNETDevelopers.Models;

namespace AngularJSforNETDevelopers.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public ActionResult Save(StudentVm student)
        {
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}