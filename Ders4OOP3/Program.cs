using System;
using System.Collections.Generic;

namespace Ders4OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtıyacKrediManager = new IhtıyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager taksitKrediManager = new TaksitKrediManager();


            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ıhtıyacKrediManager,  databaseLoggerService); //2. parametre farklı syntax kullanımı new DatabaseLogService()



            List<IKrediManager> krediler = new List<IKrediManager>();

            krediler.Add(ıhtıyacKrediManager);
            krediler.Add(konutKrediManager);
            krediler.Add(taksitKrediManager);
            //basvuruManager.KrediOnBilgilendirmeYap(krediler);
        }
    }
}
