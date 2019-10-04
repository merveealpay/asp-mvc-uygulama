using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VeriTasiyicilar.Models
{
    public class Kullanici
    {
        public Kullanici()
        {

        }
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int Boy { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
    }
}