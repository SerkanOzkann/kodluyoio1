using System;
using System.Collections.Generic;
using System.Text;

namespace _2001OOP1
{
    class ProductManager
    {
        //Ürünle ilgili operasyonlar Create-read-update-delete  CRUD = CREATE-READ-UPDATE-DELETE

        public void Add(Product2001 product)   // ekleme
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }

        public void Update(Product2001 product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }



        // public int Topla(int sayi1, int sayi2) // çıkan sonucu kullanabiliriz.çıkan sonuç bana lazım kullanabilirim.
        //{
        //    return sayi1 + sayi2;  //deger döndürür. daha sonradan Kullanabiliriz.

        //}

        //public void Topla2(int sayi1, int sayi2) // void= git-yap-bitir.
        //{
        //    Console.WriteLine(sayi1 + sayi2);

        //}

    }
}
