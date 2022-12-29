using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    //Model First Yaklaşımı
    public class UrunDB: DbContext //entity framework inheritance
    {
        //Tablo adedi kadar oluşturulur
        public DbSet<Urun> Urunler { get; set; }       //generic constraints
        public DbSet<Kategori> Kategoriler { get; set; }
    }
}