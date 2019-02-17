using EntityFrameworkCodeFirst.Modals.DB;
using EntityFrameworkCodeFirst.Modals.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            UrunlerContext ctx = new UrunlerContext();
            if (ctx.Urunler.Count() < 1)
            {
                Urun yeniurun = new Urun
                {
                    Adi = "Kalem",
                    Kategori = new Kategori { Adi = "Kırtasiye" }
                };
                ctx.Urunler.Add(yeniurun);
                ctx.SaveChanges();
            }
        }
    }
}
