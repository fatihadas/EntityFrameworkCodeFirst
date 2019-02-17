using EntityFrameworkCodeFirst.Modals.Types;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst.Modals.DB
{
    class UrunlerContext : DbContext
    {
        public DbSet<Urun> Urunler { get; set; }

        public DbSet<Kategori> Kategoriler { get; set; }

        public UrunlerContext()
        {
            Database.SetInitializer<UrunlerContext>(new CreateDatabaseIfNotExists<UrunlerContext>());
            Database.SetInitializer<UrunlerContext>(new DropCreateDatabaseIfModelChanges<UrunlerContext>());
            string temp = @"Server=.;Database=UrunlerContext;Integrated Security = True";
            Database.Connection.ConnectionString = @"Server=.;Database=UrunlerContext2;Integrated Security=True";



        }
    }
}
