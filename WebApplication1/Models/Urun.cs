using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int KategoriID { get; set; } //EF bunu kendi oluşturabilir.
        public decimal Fiyat { get; set; }

        //Nav Prop. 1-Çok Foreign Key oluşturma
        //public Kategori Kategori { get; set; }

        //Nav Prop. Çok-Çok Kompozit Key oluşturma       
        //public ICollection<Kategori> Kategoriler { get; set; }
        virtual public Kategori Kategori { get; set; }
    }
}