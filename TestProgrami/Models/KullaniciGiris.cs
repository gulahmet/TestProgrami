using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace TestProgrami.Models
{
    public class KullaniciGiris : IGiris
    {TestNameEntities db = new TestNameEntities();
       
           
     
        public void Girisi(string kullanici, string sifre)
        {
            var result = db.Kullanicis.FirstOrDefault(x => x.KullaniciAdi ==kullanici  && x.KullaniciSifre == sifre.Trim());
          
        }

        //public void Girisi(string kullaniciadi, string kullanicisifre)
        //{
        //    throw new NotImplementedException();
        //}

        public void Girisi(int KullaniciAdi, string sifre)
        {
            throw new NotImplementedException();
        }

        public void Güncelle(int id, string kullaniciadi, string kullanicisifre)
        {
            throw new NotImplementedException();
        }
    }
}