using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] {"Engin", "Murat", "Kerem", "Halil" };

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            //Arraylerde sabitlik durumu mevcuttur.

            //Arrayler yerine collectionslar kullanılır.

            Console.WriteLine("-----------");


            List<string> names2 = new List<string>();
            names2.Add("Engin");
            names2.Add("Murat");
            names2.Add("Kerem");
            names2.Add("Halil");
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Serkan");

            Console.WriteLine(names2[4]); 







            Console.ReadKey();
        }
        
    }
}
