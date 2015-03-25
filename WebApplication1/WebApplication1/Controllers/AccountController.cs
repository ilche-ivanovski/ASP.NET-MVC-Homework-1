using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public string SignIn(string userName)
        {
            FormsAuthentication.SetAuthCookie(userName, true);

            return "Authentication as: " + userName + ". Now try Member page.";
        }
        [Authorize]
        public ActionResult Member()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save()
        {
            return View();
        }
        public ActionResult Secret()
        {
            ViewBag.Color = "#ff3388";
            ViewBag.Text = "Shshshshsh It's a Secret!";
            return View();
        }
    }
}