using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4.Ders
{
    public class SatilikEv : Ev
    {
        public int SatisBedeli { get; set; }

        public override void OzellikYazdir()
        {
            Console.WriteLine("Kapı Numarası: {0} Oda Sayısı: {1} Adres: {2} Satış Bedeli: {3}", this.KapiNumarasi, this.OdaSayisi, this.Adres, this.SatisBedeli);
        }
        //public override void OzellikYazdir()
        //{
        //    Console.WriteLine("Kapı Numarası: {0} Oda Sayısı: {1} Adres: {2} Satış Bedeli: {3}", this.KapiNumarasi, this.OdaSayisi, this.Adres, this.SatisBedeli);
        //}

    }
}
