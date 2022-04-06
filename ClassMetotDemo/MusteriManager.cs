using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : " + musteri.Ad + " " + musteri.SoyAd);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : " + musteri.Ad + " " + musteri.SoyAd);
        }

        public void ListAll(params Musteri[] musteriler)
        {
            Console.WriteLine("Musteriler Listelendi.");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.SoyAd);
            }
        }
    }
}
