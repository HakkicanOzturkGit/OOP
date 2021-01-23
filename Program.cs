using System;

namespace Ders1
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety
            //Do not repeat yourself
            string CategoryTicket = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;

            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış buton");
            }
            else if(dolarDun==dolarBugun)
            {
                Console.WriteLine("dengede butonu");
            }
            else
            {
                Console.WriteLine("artıs butonu");
            }

            bool sistemeGirisYapmisMi = false;

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(CategoryTicket);


            Console.ReadLine();
        }
    }
}
