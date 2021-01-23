using System;
using System.Collections.Generic;
using System.Text;

namespace Ders2Methods
{
    class SepetManager
    {

        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklendi. "+ product.Adi);
        }

        public void Ekle2(string productName, string aciklama, double fiyat,int stokadedi)
        {
            Console.WriteLine("Sepete Eklendi. " + productName);
        }
    }
}
