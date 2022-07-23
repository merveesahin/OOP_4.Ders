using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4.Ders
{
    public class KiralikEv : Ev
    {
        public int KiraBedeli { get; set; }
        public KiralikEv(int KapiNumarasi, int OdaSayisi, string Adres) : base(KapiNumarasi, OdaSayisi, Adres)
        {
            //base.KapiNumarasi = KapiNumarasi;
            //base.OdaSayisi = OdaSayisi;
            //base.Adres = Adres;
        }

        public override void OzellikYazdir()
        {
            Console.WriteLine("Kapı Numarası: {0} Oda Sayısı: {1} Adres: {2} Kira Bedeli: {3}", this.KapiNumarasi, this.OdaSayisi, Adres, KiraBedeli);
        }

        //public override void OzellikYazdir()
        //{
        //    Console.WriteLine("Kapı Numarası: {0} Oda Sayısı: {1} Adres: {2} Kira Bedeli: {3}", this.KapiNumarasi, this.OdaSayisi, Adres, KiraBedeli);
        //}
    }
}
