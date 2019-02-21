using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Web;

namespace TestProgrami.Models
{
   
    public class OgrenciKayit : Iogrenci
    {
        TestNameEntities db = new TestNameEntities();

        public void Güncelle(string ad, string soyad, string yas, string adres)
        {
            throw new NotImplementedException();
        }

        public void Kayıtlar(string ad, string soyad, string yas, string adres)
        {

            //Ogrenci a = new Ogrenci();

            //a.Ad = ad;
            //a.Soyad = soyad;
            //a.Yas = yas;
            //a.Adres = adres;
            //var ogrenci=db.Ogrencis.Include(s && soyad)
            //         if (db.Ogrencis.Include(ad);


            //     var abc = );
            //     if (
            //        var 

            //     {

            //     }
            //     db.Ogrencis.Add(a);
            //      db.SaveChanges();



        }


        public void Sil()
        {
            throw new NotImplementedException();
        }
    }
}