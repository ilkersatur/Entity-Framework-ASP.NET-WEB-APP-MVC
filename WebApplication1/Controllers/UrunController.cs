using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        UrunDB db = new UrunDB();
        public ActionResult Index()
        {
            
            return View(db.Urunler.ToList());
        }
        //buranın varsayılanı [HttpGet]
        public ActionResult UrunEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(Urun urun)
        {
            db.Urunler.Add(urun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}