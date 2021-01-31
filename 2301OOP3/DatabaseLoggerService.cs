using System;
using System.Collections.Generic;
using System.Text;

namespace _2301OOP3
{
    class databaselogger : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı.");
        }
    }
}
