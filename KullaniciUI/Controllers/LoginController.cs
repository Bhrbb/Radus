using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace KullaniciUI.Controllers
{
    public class LoginController : Controller
    {
        // GET: AdminLogin
        RadiusContext c =  new RadiusContext();
        IKullaniciService _kullanici;
        public ActionResult Index()
        {
            return View();
        }

    }
}