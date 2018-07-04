using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School.Controllers
{
    public class HomrePageController : Controller
    {
        SchoolEntities SE = new SchoolEntities();
        // GET: HomrePage
        public ActionResult Home()
        {
            return View();
        }
        //public ActionResult basics(int? id)
        //{
        //    //if (Session["UserID"] == null)
        //    //    return RedirectToAction("Login", "common");
        //    //if (id == null)
        //    //    return View();
        //    var data1 = SE.Basics
        //        .Where(x => x.id == id)
        //        .Select(x => new Basic
        //        {
        //            id = x.id,
        //            name = x.name,
        //            emailid = x.emailid,
        //            phonenumber = x.phonenumber,
        //            message = x.message
                   
        //        }).FirstOrDefault();

        //    return View(data1);
        //}
    }
}