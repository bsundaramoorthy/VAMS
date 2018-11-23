using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VAMS.Common;

namespace VAMS.Controllers
{
    public class MasterController : Controller
    {

       public ActionResult Department()
        {
            if (SessionHelper.Current.UserID == 0)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                Common.SessionHelper.Current.CurrentPageName = "Department";
                ViewBag.Lang = SessionHelper.Current.Lang;
                return View();
            }
        }
       public ActionResult Designation()
        {
            if (SessionHelper.Current.UserID == 0)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                Common.SessionHelper.Current.CurrentPageName = "Designation";
                ViewBag.Lang = SessionHelper.Current.Lang;
                return View();
            }
        }

        public ActionResult Grade()
        {
            if (SessionHelper.Current.UserID == 0)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                Common.SessionHelper.Current.CurrentPageName = "Grade";
                ViewBag.Lang =SessionHelper.Current.Lang;
                return View();
            }
        }

    }
}