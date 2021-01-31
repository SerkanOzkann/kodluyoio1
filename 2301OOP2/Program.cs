using System;

namespace _2301OOP2
{
    class Program
    {
        //class özellik ve operasyonları tutar.2sini aynı anda tutamaz.
        //Bir sayısal değer ile matematiksel bir işlem yapılmıyorsa bu sayısal değerler string olarak tanımlanmalıdır.

        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "1234567890";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlamaio";
            musteri2.VergiNo = "2410400796";


            Musteri musteri3 = new GercekMusteri(); // new= referans no.
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);




        }
    }
}
