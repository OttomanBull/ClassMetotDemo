using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
      

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi: "+musteri.Ad+" "+musteri.Soyad+"\n");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi: " + musteri.Ad + " " + musteri.Soyad + "\n");
        }

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi: " + musteri.Ad + " " + musteri.Soyad + "\n");
        }

        public void Güncelle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Güncellendi: " + musteri.Ad + " " + musteri.Soyad + "\n");
        }

    }
}
