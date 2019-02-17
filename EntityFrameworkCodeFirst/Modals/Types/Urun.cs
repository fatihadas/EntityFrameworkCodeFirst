using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst.Modals.Types
{
    [Table("Urunler")]
    public class Urun
    {
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Adi { get; set; }
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }

    }

    [Table("Kategoriler")]
    public class Kategori
    {
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Adi { get; set; }
        public List<Urun> Urunler { get; set; }
    }
}
