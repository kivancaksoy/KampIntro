using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            /*
            List olmadan, tek elemanlı logger
            basvuruManager.BasvuruYap(tasitKrediManager, dataBaseLoggerService);
            
            alternatif olarak direkt new de yapılabilir.
            basvuruManager.BasvuruYap(tasitKrediManager, new DataBaseLoggerService());            

            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());
            */

            //List ile ibrden fazla logger
            //basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() });

            //29. satırın alternatifi
            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService()};
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager, konutKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
