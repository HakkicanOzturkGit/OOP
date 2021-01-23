using System;
using System.Collections.Generic;
using System.Text;

namespace Ders4OOP3
{
    class IhtıyacKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Ihtıyac Kredi Ödeme planı hesapladandı");
        }
    }
}
