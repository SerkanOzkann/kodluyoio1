using System;

namespace _2001OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product2001 product1 = new Product2001(); //Usage1

            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 4;

            Product2001 product2 = new Product2001 {Id=2, CategoryId=5, UnitsInStock=5, ProductName="Kalem", UnitPrice=35 };

            //pascalCase    //camelCase
            ProductManager productManager = new ProductManager();  //Usage2
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //productManager.Topla2(3,6);

            //int toplamsonuc = productManager.Topla(3, 6);

            //Console.WriteLine("Ana Sonuc: "+ toplamsonuc * 2);

            Console.ReadKey();






        }
    }
}
