using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using VeriTasiyicilar.Models;
using VeriTasiyicilar.Models.HazirListe;

namespace VeriTasiyicilar.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: Kullanici
        public ActionResult Index()
        {
            //polimorfism
            List<Kullanici> listem= new KullaniciListesi();

            return View(listem);
        }

        public ActionResult Detay(int id)
        {
            List<Kullanici> aranacakListe = new KullaniciListesi();
            //where sorgusu listelenebilir formatta data döner
            //aranacakListe.Where(x => x.Id == id).First();
            //LINQ Sorgusu 
            //Lambda Expression
           Kullanici arananKisi = aranacakListe.Find(x => x.Id == id);
            return View(arananKisi);
        }
    }
}