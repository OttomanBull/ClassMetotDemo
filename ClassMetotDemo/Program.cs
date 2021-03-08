using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager metodlar = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.Id =1;
            musteri1.Ad ="Dilvin";
            musteri1.Soyad ="ENSARİ";
            musteri1.Yas =17;


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Bahadır";
            musteri2.Soyad = "KAYHAN";
            musteri2.Yas = 20;
            

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Yıldıray";
            musteri3.Soyad = "KAYHAN";
            musteri3.Yas = 20;

            

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach (Musteri musteriListele in musteriler)
            {
                Console.WriteLine("Id: "+musteriListele.Id);
                Console.WriteLine("Ad: "+musteriListele.Ad);
                Console.WriteLine("Soyad: "+musteriListele.Soyad);
                Console.WriteLine("Yaş "+musteriListele.Yas);

                metodlar.Listele(musteriListele);

            }

            foreach (Musteri MusteriEkle in musteriler)
            {
                metodlar.Ekle(MusteriEkle);
            }

            foreach (Musteri MusteriSil in musteriler)
            {
                metodlar.Sil(MusteriSil);
            }

            foreach (Musteri MusteriGüncelle in musteriler)
            {
                metodlar.Güncelle(MusteriGüncelle);
            }







        }
    }
}
