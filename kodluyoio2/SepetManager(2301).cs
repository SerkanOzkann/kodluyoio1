using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodluyoio2
{
     class SepetManager_2301_
    {   //this is method
        public void Ekle(Product2301 urun) // naming convention = metotun ilk harfi büyük 
        {
            Console.WriteLine("Sepete Eklendi:"+ urun.Adi);
        }
        //Bir classın içinde birden fazla method olabilir.
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Sepete Eklendi:" + urunAdi);
        }
    }
}
