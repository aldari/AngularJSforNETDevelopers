using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularJSforNETDevelopers.Models;

namespace AngularJSforNETDevelopers.Controllers
{
    public class AccountController : ApiController
    {
        public HttpResponseMessage Post(StudentVm student)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}