using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VeriTasiyicilar.Models;

namespace VeriTasiyicilar.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Kullanici model = new Kullanici { AdSoyad="Fatma Betül YILMAZ", Boy=178, DogumTarihi=new DateTime(1976, 12,12), Email="fbetulakdemirr@gmail.com", Id=1, Telefon="05437425342" };

            ViewBag.Aciklama = "Kullanıcı bilgileri getirildi.";
            ViewBag.SistemSaati = DateTime.Now;
            ViewBag.AdSoyad = new Kullanici {AdSoyad= "Merve Alpay", Id=2 };

            ViewData["Username"] = "fby";
            ViewData["dict"] = new ViewDataDictionary { {"age","16"}, {"school","Fatih IT School" } };

            return View(model);
        }

        public ActionResult Sepet()
        {
            TempData["Kitap"] = "Kitap sepete tempdata ile eklendi.";
            ViewBag.Kitap = "Kitap sepete viewbag ile eklendi.";
            ViewData["KitapData"] = "Kitap sepete viewdata ile eklendi.";
            //return View();
            return RedirectToAction("SatinAl");
        }

        public ActionResult SatinAl()
        {
            return View();
        }
    }
}