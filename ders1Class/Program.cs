using System;

namespace ders1Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "haqqı";
            int yas = 25;
            Kurs kurs1 = new Kurs();
            Kurs kurs2 = new Kurs();
            Kurs kurs3 = new Kurs();

            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "haqqı";
            kurs1.IzlenmeOrani = 65;

            kurs2.KursAdi = "java";
            kurs2.Egitmen = "ali";
            kurs2.IzlenmeOrani = 44;


            kurs3.KursAdi = "pyton";
            kurs3.Egitmen = "ahmet";
            kurs3.IzlenmeOrani = 72;

            //Console.WriteLine(kurs1.KursAdi + " : "+kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var item in kurslar)
            {
                Console.WriteLine(item.KursAdi + " : "+ item.Egitmen);
            }

        }
    }

    public class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int  IzlenmeOrani{ get; set; }
    }
}
