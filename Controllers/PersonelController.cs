using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mubco_Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mubco_Proje.Controllers
{
    public class PersonelController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Personels.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniPersonel()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniPersonel(Personel p)
        {
            c.Personels.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult PersonelSil(int id)
        {
            var per = c.Personels.Find(id);
            c.Personels.Remove(per);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult PersonelGetir(int id)
        {
            var per = c.Personels.Find(id);
            return View("PersonelGetir", per);
        }

        public IActionResult PersonelGuncelle(Personel p)
        {
            var per = c.Personels.Find(p.PerID);
            per.Ad = p.Ad;
            per.Soyad = p.Soyad;
            per.Sehir = p.Sehir;
            per.Birim = p.Birim;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
