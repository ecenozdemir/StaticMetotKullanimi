using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMetotKullanimi
{
    public static class Personel
    {
        public static void isimSoyisimYazdir()
        {
            Console.WriteLine("Ece Özdemir");
        }

        public static void sayilariTopla(int sayi1, int sayi2)
        {
            Console.WriteLine("İki sayının toplamı: "+ (sayi1+sayi2));
        }
    }
}
