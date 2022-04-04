using System;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış oku");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış oku.");
            }
            else
            {
                Console.WriteLine("Eşittir oku.");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
