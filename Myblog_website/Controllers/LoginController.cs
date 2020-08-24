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
            var list_Acc = (from acc in data.tblAccounts where acc.userName == account.userName && acc.pass_Word == account.pass_Word select acc).FirstOrDefault() ;
            if(list_Acc != null)
            {
                var img = (from avata in data.tblUsers where avata.id_acc == list_Acc.id_acc && avata.avata_img != null select avata.avata_img).FirstOrDefault();
                var nickname = (from nick in data.tblUsers where nick.id_acc == list_Acc.id_acc select nick.nickName).FirstOrDefault();
                var idUser = (from nick in data.tblUsers where nick.id_acc == list_Acc.id_acc select nick.id_User).FirstOrDefault();
                if (img != null)
                {
                    Session["avata-img"] = img;
                }
                Session["idUser"] = idUser;
                Session["nickName"] = nickname;
                Session["Account"] = list_Acc;
                return Json(new { Result = "true" });
            }
            return View("Index_Login");
        }

        [HttpPost]
        public ActionResult SignUp(tblAccount account, tblUser usertbl)
        {
            var listacc = (from acc_check in data.tblAccounts where acc_check.userName == account.userName select acc_check).FirstOrDefault();
            if(listacc == null)
            {
                using (data)
                {
                    try
                    {
                        tblAccount acc = new tblAccount();
                        acc = account;
                        data.tblAccounts.Add(acc);
                        data.SaveChanges();
                        int idacc = data.tblAccounts.Max(id => id.id_acc);
                        tblUser User = new tblUser();
                        User.id_acc = idacc;
                        User.nickName = usertbl.nickName;
                        data.tblUsers.Add(User);
                        data.SaveChanges();

                        Session["account"] = acc;
                        Session["nickName"] = usertbl.nickName;
                        return Json(new { Result = "True" });
                    }
                    catch(Exception ex)
                    {
                        return Json(new { Result = ex });
                    }
                }
            }
            else
            {
                return Json(new { Result = "Tài khoản đã tồn tại" });
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