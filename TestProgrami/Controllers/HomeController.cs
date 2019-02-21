using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TestProgrami.Models;

namespace TestProgrami.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        TestNameEntities db = new TestNameEntities();
        // GET: Home
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Giris(Kullanici Model)
        {
            try
            {
              if(Model == null)
            {
                ViewBag.Mesaj = "Şifreniz yada Kullanici Adiniz Yanlistir";
                return View("Index");
            }
            else
            { 
            KullaniciGiris abc = new KullaniciGiris();
            abc.Girisi(Model.KullaniciAdi,Model.KullaniciSifre);
                FormsAuthentication.SetAuthCookie(Model.KullaniciAdi, false);
                return RedirectToAction("Anasayfa", "Anasayfa");
        }
            }
            catch (Exception)
            {

                return HttpNotFound();
            }
          } 

       
        [Authorize]
        public ActionResult Logout()
        {
            if (String.IsNullOrEmpty(HttpContext.User.Identity.Name))
            {
                FormsAuthentication.SignOut();
                return View("Index");
            }
            return Redirect("Index");

        }
    }
}