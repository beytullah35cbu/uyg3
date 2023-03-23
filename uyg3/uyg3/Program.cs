using System;

namespace ArabaApp
{
    class Araba
    {
        public string Marka;
        public short Model;
        public string Renk;
        private decimal FiyatKDVsiz;
        public decimal Fiyat
        {
            get { return FiyatKDVsiz * 1.18m; }//değer atamak
            set { FiyatKDVsiz = value; }//okumak
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();//bellekte yenı alan
            araba.Marka = "Toyota";//{0}dan başlar 
            araba.Model = 2022;
            araba.Renk = "Siyah";
            araba.Fiyat = 100000;

            Console.WriteLine("{0} {1} model arabanın {2} rengi vardır ve fiyatı KDV dahil {3} TL'dir.", araba.Marka, araba.Model, araba.Renk, araba.Fiyat);

            Console.ReadKey();
        }
    }
}


