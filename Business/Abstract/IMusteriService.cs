using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMusteriService
    {
        void ekle(Musteri musteri);
        void sil(Musteri musteri);
        void getMusteri(Musteri musteri);
    }
}
