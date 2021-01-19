using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziMetotSinif
{
    class Program
    {
        static void Main(string[] args)
        {
            kutuphane kh = new kutuphane();

            string secenek = "e";
            while (secenek == "e")
            {
                Kitap k = new Kitap();
                Console.WriteLine("Kitap:");
                k.isim = Console.ReadLine();
                Console.WriteLine("yazar:");
                k.yazar = Console.ReadLine();
                Console.WriteLine("Basım yılı:");
                k.basimYili = Console.ReadLine();
                Console.WriteLine("fiyat:");
                k.fiyat = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Stok:");
                k.stok = Convert.ToInt32(Console.ReadLine());
                kh.Ekle(k);

                Console.WriteLine("Eklemeye devam edilsin mi?");
                secenek = Console.ReadLine();
            }
            kh.Yazdir();

        }
    }
}
