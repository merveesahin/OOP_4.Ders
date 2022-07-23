using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4.Ders
{
    public class Dikdortgen : IGeometry
    {
        public void AlanHesapla(int uzunkenar, int kisakenar)
        {
            Console.WriteLine("Dikdörtgenin Alanı: {0}", uzunkenar*kisakenar);
        }

        public void CevreHesapla(int uzunkenar, int kisakenar)
        {
            Console.WriteLine("Dikdörtgenin Çevresi: {0}", (uzunkenar + kisakenar)*2); 
        }
    }
}
