using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziMetotSinif
{
    class kutuphane
    {
        public Kitap[] kitaplar;

        public kutuphane()
        {
            kitaplar = new Kitap[0];
        }

        public void Ekle(Kitap ki)
        {
            Kitap[] gecici = new Kitap[kitaplar.Length + 1];
            Array.Copy(kitaplar, gecici, kitaplar.Length);
            gecici[gecici.Length - 1] = ki;
            kitaplar = gecici;
        }

        public void Yazdir()
        {
            foreach (Kitap item in kitaplar)
            {
                Console.WriteLine(item.isim + " " + item.yazar+" "+item.fiyat+" TL");
            }
        }
    }
}
