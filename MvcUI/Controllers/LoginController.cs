using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Busines.Abstract;
   


namespace MvcUI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

         IKullaniciService _kullanici;
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();

        }
        [HttpPost]
        public ActionResult AdminLogin(string Email,string Sifre)
        {
            
            //if (bilgiler != null)
            //{
            //    FormsAuthentication.SetAuthCookie(bilgiler.CariMail, false);
            //    Session["CariMail"] = bilgiler.CariMail.ToString();
            //    return RedirectToAction("Index", "CariPanel");
            //}
            //else
               return View();
        }
    }
}