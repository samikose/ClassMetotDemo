using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            string hitap;
            if(musteri.Cinsiyet == "Erkek")
            {
                hitap = "Bey";
            }
            else
            {
                hitap = "Hanım";
            }
            Console.WriteLine("Müşteri eklendi,bizi tercih ettiğiniz için teşekkürler "+musteri.Ad +" "+hitap);
        }

        public void listele(Musteri musteriListele)
        {
            Console.WriteLine(musteriListele.musteriId +" "+ musteriListele.Ad +" "+ musteriListele.Soyad +" "+ musteriListele.Tc_no +" "+ musteriListele.Tel_no +" "+ musteriListele.Cinsiyet+" "+"Veriler listelendi ");
        }

        public void sil(Musteri musteriSil)
        {
            Console.WriteLine(musteriSil.musteriId+"Id'li musteri silindi");
        }

    }
}
