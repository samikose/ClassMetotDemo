using Business.Concrete;
using Entities.Concrete;
using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Sami";
            musteri1.Soyad = "Köse";
            musteri1.Bakiye = 2700;


            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Ömer";
            musteri2.Soyad = "Faruk";
            musteri2.Bakiye = 2270;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Selin";
            musteri3.Soyad = "Işık";
            musteri3.Bakiye = 3607;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.ekle(musteri1);
            musteriManager.ekle(musteri2);
            musteriManager.ekle(musteri3);

            musteriManager.sil(musteri3);

            musteriManager.getMusteri(musteri3);
        }
    }
}
