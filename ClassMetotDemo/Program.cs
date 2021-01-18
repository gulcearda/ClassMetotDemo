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






            Console.WriteLine("--------MetotlarDemo--------");

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);
            musterimanager.Ekle(musteri3);
            musterimanager.Ekle(musteri4);
            musterimanager.Ekle(musteri5);


            Console.WriteLine("Hello World!");

        }
    }
}
