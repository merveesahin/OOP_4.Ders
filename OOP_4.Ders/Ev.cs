using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4.Ders
{
    public abstract class Ev
    {
        private int kapiNumarasi;
        public int OdaSayisi { get; set; }
        public int KapiNumarasi
        {
            get
            {
                return kapiNumarasi;
            }
            set
            {
                if (value>100)
                {
                    Console.WriteLine("Kapı Numarası 100den büyük olamaz...");
                }
                else
                {
                    this.kapiNumarasi = value;
                }
            }
        }

        public string Adres { get; set; }
        public Ev(int KapiNumarasi, int OdaSayisi, string Adres)
        {
            this.kapiNumarasi = KapiNumarasi;
            this.OdaSayisi = OdaSayisi;
            this.Adres = Adres;
        }
        public Ev()
        {

        }
        public abstract void OzellikYazdir();
        //public virtual void OzellikYazdir()
        //{
        //    Console.WriteLine("Kapı Numarası: {0} Oda Sayısı: {1} Adres:{2}", this.kapiNumarasi, this.OdaSayisi, Adres );
        //}
    }
}
