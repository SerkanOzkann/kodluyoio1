using System;
using System.Collections.Generic;
using System.Text;

namespace _2301OOP3
{
    class BasvuruManager
    {   // method injection
        public void BasvuruYap(IKrediManager    krediManager, List<ILoggerService> loggerServices)
        {
            //basvuran bilgilerini degerlendirme.
           
         krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
