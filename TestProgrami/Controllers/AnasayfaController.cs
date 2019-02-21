using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProgrami.Models;

namespace TestProgrami.Controllers
{  [Authorize]
    public class AnasayfaController : Controller
    {
        TestNameEntities db = new TestNameEntities();
        // GET: Anasayfa

        public ActionResult Anasayfa()
        {
            var ogrModel = db.Ogrencis.ToList();
            return View(ogrModel);
        }


        [HttpPost]
       
        public ActionResult Gonder(Ogrenci cc)
            {
            try
            {
                if (cc.Ad !=null && cc.Soyad !=null && cc.Adres !=null && cc.Yas !=null)
            {
                //OgrenciKayit abc = new OgrenciKayit();
                //abc.Kayıtlar(cc.Ad, cc.Soyad, cc.Yas, cc.Adres);
                //var adaa = db.Ogrencis.Where(x => x.Ad == cc.Ad && x.Soyad == cc.Soyad && x.Yas==cc.Yas && x.Adres==cc.Adres);
                db.Ogrencis.Add(cc);
                db.SaveChanges();
             
            }
              
            return View();

            }
            catch (Exception)
            {

                return HttpNotFound();
            }
         
        }
    }
}