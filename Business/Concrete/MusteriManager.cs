using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class MusteriManager : IMusteriService
    {
        static int i = 1;
        List<Musteri> musteriler = new List<Musteri>();
        public void ekle(Musteri musteri)
        {
            musteri.Id = i;
            i++;
            musteriler.Add(musteri);
            Console.WriteLine(musteri.Ad +" adlı musteri eklendi");
        }

        public void getMusteri(Musteri musteri)
        {
            bool musteriVarMi = false;
            foreach (Musteri musteriG in musteriler)
            {
                if(musteri.Id == musteriG.Id)
                {
                    Console.WriteLine("Ad: " + musteri.Ad + " Soyad: " + musteri.Soyad + " Bakiye: "+ musteri.Bakiye);
                    musteriVarMi = true;
                }
            }
            if (musteriVarMi == false)
            {
                Console.WriteLine("Müşteri bulunamadı.");
            }
        }

        public void sil(Musteri musteri)
        {
            musteriler.Remove(musteri);
            Console.WriteLine(musteri.Ad + " adlı musteri silindi");
        }
    }
}
