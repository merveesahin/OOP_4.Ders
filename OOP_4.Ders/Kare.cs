using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4.Ders
{
    public class Kare : IGeometry
    {
        public void AlanHesapla(int uzunkenar, int kisakenar)
        {
            Console.WriteLine("Karenin Alanı: {0}", uzunkenar * kisakenar);
        }

        public void CevreHesapla(int uzunkenar, int kisakenar)
        {
            Console.WriteLine("Karenin Çevresi: {0}", 2* (uzunkenar + kisakenar));
        }
    }
}
