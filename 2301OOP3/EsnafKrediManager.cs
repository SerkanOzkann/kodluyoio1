using System;
using System.Collections.Generic;
using System.Text;

namespace _2301OOP3
{
    class EsnafKrediManager : IKrediManager
    {
        public void Bisey()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf Kredisi ödeme planı hesaplandı.");
        }
    }
}
