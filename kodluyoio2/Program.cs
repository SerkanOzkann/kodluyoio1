using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodluyoio2
{
    class Program
    {
         static void Main(string[] args)
        { //date 23-01-2021 - METOTLAR
          //tekrar tekrar kullanabilirliği sağlayan bir ortam sunar.
          //classlar özellik tutabilirler (ürün özellikleri)

            string urunAdi = "elma";
            double fiyati = 15;
            string aciklama = "amasya,yerli";

            string[] meyveler = new string[] { };

            Product2301 urun1 = new Product2301();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Yerli,amasya";

            Product2301 urun2 = new Product2301();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır";

            Product2301[] urunler = new Product2301[] { urun1,urun2 };

            foreach  (Product2301 urun in urunler)
            {
                Console.WriteLine("---------------");
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
            

            }
            Console.WriteLine("-----Methods-----");

            //instante örnek
            //encapsulation=kapsülleme=düzen
            SepetManager_2301_ sepetManager = new SepetManager_2301_();

            sepetManager.Ekle(urun1);

            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "taze", 12);
            sepetManager.Ekle2("elma", "yeşil", 18);
            sepetManager.Ekle2("karpuz", "diyarbakir", 14);



            Console.ReadKey();

        }
    }
}
