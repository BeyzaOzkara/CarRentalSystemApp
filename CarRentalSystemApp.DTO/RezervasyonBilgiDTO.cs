using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarRentalSystemApp.DTO
{
    public class RezervasyonBilgiDTO
    {
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Araclar")]
        public int RezervasyonID { get; set; }
        public int AracID { get; set; }
        public int MusteriID { get; set; }
        //[Column(TypeName = "date")]
        public DateTime BaslangicTarihi { get; set; }
        //[Column(TypeName = "date")]
        public DateTime TeslimTarihi { get; set; }
        public float AnlikKm { get; set; }
        public float SonKm { get; set; }
        //[Column(TypeName = "money")]
        public Decimal AlinanUcret { get; set; }
        public virtual MusterilerDTO MusterilerDTO { get; set; }
        public virtual AraclarDTO AraclarDTO { get; set; } 
    }
}
