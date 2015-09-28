using System.Web.Mvc;
using System.Web.Security;

namespace App1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}