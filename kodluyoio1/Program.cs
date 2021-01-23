using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodluyoio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety- tip güvenligi
            string kategoriEtiketi = "Kategori";

            int ogrenciSayisi = 32000;
            double faiz = 1.45;
            bool sistemeGirmisMi = false;

            double dolarDun = 7.35;
            double dolarBugun = 7.35;

            if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Dolar Yükseldi");

            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("dolar düştü");
            }
            else
            {
                Console.WriteLine("Dolar değişmedi");
            }




            if (sistemeGirmisMi == true)
            {
                Console.WriteLine("Giriş başarılı");

            }
            else
            {
                Console.WriteLine("Giriş başarısız");
            }


            Console.WriteLine(kategoriEtiketi);

            //string k1 = "YazGelKam";
            //string k2 = "Programlamaya Baslangıc";
            //string k3 = "Java";

            //array-dizi

            string[] kurslar = new string[] { "YazGelKam", "Programlamaya Baslangıc", "Java" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("---------------------------");
            foreach (string kurs in kurslar)
            {
                // dizileri tek tek dolasmaya yarar.

                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");
            Console.WriteLine("---------------------------");



            Kurs ku1 = new Kurs();
            ku1.Egitmen = "engin";
            ku1.Kursadı = "c#";
            ku1.izlenmeOranı = 68;

            Kurs ku2 = new Kurs();
            ku2.Egitmen = "serkan";
            ku2.Kursadı = "java";
            ku2.izlenmeOranı = 61;

            Kurs ku3 = new Kurs();
            ku3.Egitmen = "mert";
            ku3.Kursadı = "python";
            ku3.izlenmeOranı = 100;
            Console.WriteLine(ku1.Kursadı + ":" + ku1.Egitmen);

            Kurs[] kurslarr = new Kurs[] { ku1,ku2,ku3};

            foreach(var kurs in kurslarr)
            {
                Console.WriteLine(kurs.Kursadı + ":" + kurs.Egitmen);
            }

            Console.ReadKey();
        }
        
        class Kurs
        {
            public string Kursadı { get; set; }

            public string Egitmen { get; set; }

            public int  izlenmeOranı { get; set; }
        }


            
        }
    }

