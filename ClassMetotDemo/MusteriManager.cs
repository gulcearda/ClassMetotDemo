using System;
namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " " + "isimli müşterimiz bankamıza katıldı.");
        }

        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.HesapSayisi);
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " " + "isimli müşterimiz bankamızdan ayrıldı.");
        }
    }
}
