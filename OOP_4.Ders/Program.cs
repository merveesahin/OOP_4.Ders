using System;

namespace OOP_4.Ders
{
    class Program
    {
        static void Main(string[] args)
        {
            //KiralikEv kiralikev = new KiralikEv(10, 4, "İstanbul");
            //SatilikEv satilikev = new SatilikEv();
            //Ev ev = new Ev();

            IGeometry geometrikSekil = new Dikdortgen();
            geometrikSekil.AlanHesapla(4, 5);
            geometrikSekil.CevreHesapla(5, 7);
        }
    }
}
