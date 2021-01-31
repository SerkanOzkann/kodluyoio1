using System;
using System.Collections.Generic;
using System.Text;

namespace _2301OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void Bisey()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }
    }
}
