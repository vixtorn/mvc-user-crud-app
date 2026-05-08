using Microsoft.AspNetCore.Mvc;
using DatabaseDeneme.Data;
using DatabaseDeneme.Models;
using System.Linq;

namespace DatabaseDeneme.Controllers
{
    public class HomeController : Controller
    {
        private readonly UygulamaDbContext _context;

        public HomeController(UygulamaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Users tablosundaki verileri listeye çevirip View'a gönderiyoruz
            var liste = _context.Users.ToList();
            return View(liste);
        }

        // URL'den gelen ID parametresini yakalar
        public IActionResult Delete(int id)
        {
            // 1. Veritabanından bu ID'ye sahip kullanıcıyı bul
            var silinecekKullanici = _context.Users.Find(id);

            // 2. Eğer kullanıcı gerçekten varsa != null değilse silme işlemine başla
            if (silinecekKullanici != null)
            {
                _context.Users.Remove(silinecekKullanici); // Entity Framework'e silme emri ver
                _context.SaveChanges(); // Değişiklikleri MSSQL'e kaydet
            }

            // 3. İşlem bitince anasayfaya (Index) geri dön ve tabloyu yeniden yükle
            return RedirectToAction("Index");
        }

        // 1. AŞAMA: Düzenleme sayfasını açan metot (GET)
        public IActionResult Edit(int id)
        {
            // Veritabanından o ID'li kişiyi bul
            var kisi = _context.Users.Find(id);

            if (kisi == null) return NotFound();

            // Kişiyi bulduk, şimdi onu düzenleme sayfasına (View) gönderiyoruz
            return View(kisi);
        }

        // 2. AŞAMA: Formdan gelen güncel veriyi kaydeden metot (POST)
        [HttpPost] // Bu metodun sadece form gönderildiğinde çalışacağını belirtir
        public IActionResult Edit(Kisi guncelVeri)
        {
            // Veritabanındaki eski kaydı bulup güncelliyoruz
            _context.Users.Update(guncelVeri);
            _context.SaveChanges();

            // İşlem bitince listeye geri dön
            return RedirectToAction("Index");
        }
    }
}

