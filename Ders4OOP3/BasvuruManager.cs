using System;
using System.Collections.Generic;
using System.Text;

namespace Ders4OOP3
{
    class BasvuruManager
    {
        //Method Injection >>Dependency Injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) //Hangı cesıt kredı gönderırsem onun referansı calısır. konut,tasit vb.
        {
            //Basvuran bilgilerini degerlendirme

            //KonutKrediManager konutKrediManager = new KonutKrediManager();  // Yanlıs gereksiz.
            //konutKrediManager.Hesapla();

            krediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmeYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
