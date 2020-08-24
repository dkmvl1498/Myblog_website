using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Myblog_website.Models;

namespace Myblog_website.Controllers
{
    public class HomeController : Controller
    {
        public BlogerWebsiteEntities data = new BlogerWebsiteEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Profile_Page()
        {
            int id = int.Parse(Session["idUser"].ToString());
            var info_User = (from infoU in data.tblUsers where infoU.id_User == id select infoU).FirstOrDefault();
            ViewBag.View_info_User = info_User;
            return View();
        }

        public PartialViewResult ProFile_edit()
        {
            int id = int.Parse(Session["idUser"].ToString());
            var info_User = (from infoU in data.tblUsers where infoU.id_User == id select infoU).FirstOrDefault();
            ViewBag.View_info_User = info_User;
            return PartialView();
        }

        [HttpPost]
        public JsonResult editName(String value, string idedit)
        {
            using (data)
            {
                try
                {
                    int iduser = int.Parse(Session["idUser"].ToString());
                    var infoUser = (from us in data.tblUsers where us.id_User == iduser select us).FirstOrDefault();
                    if(idedit == "name")
                    {
                        infoUser.name_User = value;
                    }    
                    if(idedit == "nickname")
                    {
                        infoUser.nickName = value;
                    }  
                    //if(idedit == "dateOfBirth")
                    //{
                    //    infoUser.date_Of_Birth = value;
                    //}
                    if(idedit == "titleUser")
                    {
                        infoUser.title_User = value;
                    }
                    data.SaveChanges();
                    return Json(new { Result = "True" });
                }
                catch(Exception ex)
                {
                    return Json(new { Result = ex });
                }
            }
        }
    }
}