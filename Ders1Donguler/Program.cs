using System;

namespace Ders1Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım gelistirici kampı";
            string kurs2 = "Programlama temel kurs";
            string kurs3 = "Java";

            string[] kurslar = new string[] { kurs1,kurs2,kurs3};

            //Console.WriteLine(kurslar); hatalı
            
            //for (int i = 0; i<kurslar.Length; i++)
            //{
            //    Console.WriteLine(kurslar[i]);
            //}

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
