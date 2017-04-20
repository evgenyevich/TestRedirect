using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestRedirect.Models;

namespace TestRedirect.Controllers
{
    public class HomeController : Controller
    {
        //private RedirectRights _redirectRights;
        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "None")]
        public ActionResult Index(RedirectRights _redirectRights=null)
        {
            if (_redirectRights == null)
            {
                _redirectRights = new RedirectRights {Qty = 0};
            }
            if (_redirectRights.Qty == RedirectRights.RedirectQty)
            {
                return View(_redirectRights);
            }
            else
            {
                return View("FalseView");
            }
           
        }
        //[HttpPost]
        //public ActionResult Index(RedirectRights redirectRights)
        //{
        //    redirectRights.RedirectQty++;
        //    _redirectRights = redirectRights;
        //    return View("Index", _redirectRights);
        //    //if (redirectResult.CanRedirect)
        //    //{
        //    //    return View("TrueView", redirectResult);
        //    //}
        //    //else
        //    //{

        //    //     return View("FalseView", redirectResult);
        //    //}

        //}
        [HttpPost]
        //[OutputCache(NoStore = true, Duration = 0, VaryByParam = "None")]
        public ActionResult ApplyResult(RedirectRights redirectRights)
        {
            RedirectRights.RedirectQty++;
            redirectRights.Qty = RedirectRights.RedirectQty;
            return RedirectToAction("Index", redirectRights);
        }
    }
}