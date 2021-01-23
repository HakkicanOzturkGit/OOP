using System;

namespace Ders4OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //engin
            GercekMusteri musteri1 = new GercekMusteri();

            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "234324324";

            TuzelMusteri musteri2 = new TuzelMusteri();

            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.İO";
            musteri2.VergiNo = "213124324";

            //SOLID >>L


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager cm = new CustomerManager();
            cm.Add(musteri3);
            cm.Add(musteri4);
            cm.Add(musteri1);


        }
    }
}
