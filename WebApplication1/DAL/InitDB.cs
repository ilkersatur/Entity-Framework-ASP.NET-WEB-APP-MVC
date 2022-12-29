using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.DAL;
using WebApplication1.Models;
namespace WebApplication1.DAL
{
    public class InitDB:DropCreateDatabaseAlways<UrunDB>
    {
        protected override void Seed(UrunDB context)
        {
            base.Seed(context);
            context.Kategoriler.Add(new Kategori(){ KategoriAdi = "Kırtasiye" });
            context.Kategoriler.Add(new Kategori(){ KategoriAdi = "Elektroink" });
            context.Kategoriler.Add(new Kategori(){ KategoriAdi = "Hediye" });

            context.SaveChanges();

            context.Urunler.Add(new Urun { UrunAdi="Defter",KategoriID=1,Fiyat=45});
            context.Urunler.Add(new Urun { UrunAdi="Pergel",KategoriID=1,Fiyat=28});
            context.Urunler.Add(new Urun { UrunAdi="Cep Telefonu",KategoriID=2,Fiyat=10934});
            context.Urunler.Add(new Urun { UrunAdi="Kitap",KategoriID=3,Fiyat=10});
            context.Urunler.Add(new Urun { UrunAdi="Anahtarlık",KategoriID=3,Fiyat=5});

            context.SaveChanges();
        }
        
    }
}