using System;
using System.Collections.Generic;

namespace _2301OOP3
{
    class Program
    {
        static void Main(string[] args)
        {   //interface o classı tutabilir.
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaselogger = new databaselogger();
            ILoggerService filelogger = new FileLoggerService();
            ILoggerService smslogger = new SmsLoggerServices();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerServices(), new FileLoggerService(), new databaselogger() };

            BasvuruManager basvuruManager = new BasvuruManager();
           basvuruManager.BasvuruYap(tasitKrediManager,  loggers);


            basvuruManager.BasvuruYap(konutKrediManager,loggers);
            basvuruManager.BasvuruYap(esnafKrediManager, loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager, konutKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            Console.ReadKey();

        }

       
    }
}
