using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Myblog_website.ViewModel;
using Myblog_website.Models;

namespace Myblog_website.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public BlogerWebsiteEntities data = new BlogerWebsiteEntities();
        public ActionResult Index_Login()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult CheckLogin(tblAccount account)
        {
            var list_Acc = (from acc in data.tblAccounts where acc.userName == account.userName && acc.pass_Word == account.pass_Word select acc).FirstOrDefault();
            if(list_Acc != null)
            {
                Session["Account"] = list_Acc;
                return Json(new { Result = "true" });
            }
            return View("Index_Login");
        }

        public ActionResult Log_Out()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}