using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "YazGelKam", "Programlamaya Baslangıc", "Java" };


            for (int i = 0; i <= kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
        }
    }
}
