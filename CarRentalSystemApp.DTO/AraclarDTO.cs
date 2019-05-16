using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystemApp.DTO
{
    public class AraclarDTO
    {
        public int AracID { get; set; }

        public int SirketID { get; set; }

        public string Marka { get; set; }

        public string Model { get; set; }

        public int EhliyetYasi { get; set; }

        public int MinYasSiniri { get; set; }

        public float GunukKm { get; set; }

        public float AnlikKm { get; set; }

        public byte Airbag { get; set; }

        public int BagajHacmi { get; set; }

        public int KoltukSayisi { get; set; }

        public Decimal GunlukKiralikFiyati { get; set; }

        public Boolean Durum { get; set; }
        
    }
}
