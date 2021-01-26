using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriId = 01;
            musteri1.Ad = "Sami";
            musteri1.Soyad = "Köse";
            musteri1.Tc_no = 37018039180;
            musteri1.Adres = "Bursa/Gemlik";
            musteri1.Tel_no = 05464200582;
            musteri1.Cinsiyet = "Erkek";

            Musteri musteri2 = new Musteri();
            musteri2.musteriId = 02;
            musteri2.Ad = "Selinay";
            musteri2.Soyad = "Özağır";
            musteri2.Tc_no = 11122233344;
            musteri2.Adres = "Bursa/Gemlik";
            musteri2.Tel_no = 05424514737;
            musteri2.Cinsiyet = "Kadın";

            Musteri musteri3 = new Musteri();
            musteri3.musteriId = 03;
            musteri3.Ad = "Ömer";
            musteri3.Soyad = "Faruk";
            musteri3.Tc_no = 48953261753;
            musteri3.Adres = "Bursa/Gemlik";
            musteri3.Tel_no = 05361245897;
            musteri3.Cinsiyet = "Erkek";

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.musteriId);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Tc_no);
                Console.WriteLine(musteri.Adres);
                Console.WriteLine(musteri.Tel_no);
                Console.WriteLine(musteri.Cinsiyet);
            }
            MusteriManager musterimanager = new MusteriManager();

            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);
            musterimanager.Ekle(musteri3);

            Console.WriteLine("-------Musteriler eklendi-------" );
            musterimanager.listele(musteri3);

            Console.WriteLine("------------müşteri listelendi--------------");

            musterimanager.sil(musteri2);

        }
    }
}
