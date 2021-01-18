using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 93;
            musteri1.Adi = "Dilmer";
            musteri1.Soyadi = "Vilca";
            musteri1.HesapSayisi = 3;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 65;
            musteri2.Adi = "Ayşe";
            musteri2.Soyadi = "Üstün";
            musteri2.HesapSayisi = 1;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 22;
            musteri3.Adi = "Ahmet";
            musteri3.Soyadi = "Sporcu";
            musteri3.HesapSayisi = 2;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 44;
            musteri4.Adi = "Hilal";
            musteri4.Soyadi = "Marmara";
            musteri4.HesapSayisi = 4;

            Musteri musteri5 = new Musteri();
            musteri5.Id = 36;
            musteri5.Adi = "Ender";
            musteri5.Soyadi = "Kuyumcu";
            musteri5.HesapSayisi = 2;





            MusteriManager musteriEkle = new MusteriManager();
            musteriEkle.Ekle(musteri1);
            musteriEkle.Ekle(musteri2);
            musteriEkle.Ekle(musteri3);
            musteriEkle.Ekle(musteri4);
            musteriEkle.Ekle(musteri5);

            MusteriManager musteriListe = new MusteriManager();
            musteriListe.Listeleme(musteri1);
            musteriListe.Listeleme(musteri2);
            musteriListe.Listeleme(musteri3);
            musteriListe.Listeleme(musteri4);
            musteriListe.Listeleme(musteri5);

            MusteriManager musteriSilme = new MusteriManager();
            musteriSilme.Silme(musteri1);
            musteriSilme.Silme(musteri2);
            musteriSilme.Silme(musteri3);
            musteriSilme.Silme(musteri4);
            musteriSilme.Silme(musteri5);

           

        }
    }
}
