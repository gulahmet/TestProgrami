

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgrami.Models
{
    interface IGiris
    {
        void Girisi(string kullanici,string sifre);
        void Güncelle(int id, string kullaniciadi, string kullanicisifre);
       
       
    }
}
