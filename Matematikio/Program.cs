using System;

namespace Matematikio
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslemio dortislem = new DortIslemio();
            dortislem.Topla(5, 6);

            dortislem.Topla(9, 5);

            Console.ReadKey();
        }
    }
}
