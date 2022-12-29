using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Kategori
    {
        //Entity ID görürse primary key olarak kabul eder.
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        //navigation property
        //public ICollection<Urun> Urunler { get; set; }
        virtual public ICollection<Urun> Urunler { get; set; }
    }
}