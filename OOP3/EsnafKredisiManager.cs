using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafKredisiManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calc()
        {
            Console.WriteLine("Esnaf kredisi ödeme planı oluşturuldu.");
        }
    }
}
