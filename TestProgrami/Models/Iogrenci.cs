using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgrami.Models
{
    interface Iogrenci
    {
        void Sil();
        void Kayıtlar(string ad, string soyad, string yas,string adres);
        void Güncelle(string ad, string soyad, string yas, string adres);
    }
}
