using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Myblog_website.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index_Login()
        {
            return PartialView();
        }
    }
}