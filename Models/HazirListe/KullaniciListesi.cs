using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VeriTasiyicilar.Models.HazirListe
{
    public class KullaniciListesi :List<Kullanici>
    {
        public KullaniciListesi()
        {
            this.Add(new Kullanici {Id=1, AdSoyad = "Büşra Zurnacı", DogumTarihi = new DateTime(1990, 12, 12) });
            this.Add(new Kullanici {Id=2, AdSoyad = "Petek Okumuşoğlu", DogumTarihi = new DateTime(1990, 12, 12) });
            this.Add(new Kullanici {Id=3, AdSoyad = "Yavuz Selim Çınar", DogumTarihi = new DateTime(1990, 12, 12) });
            this.Add(new Kullanici {Id=4, AdSoyad = "Mehmet Turgut", DogumTarihi = new DateTime(1990, 12, 12) });
        }
    }
}
