using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRentalSystemApp.Extensions;
using CarRentalSystemApp.DTO;
using CarRentalSystemApp.Models;

namespace CarRentalSystemApp.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MapToTest()
        {
            Araclar arc = new Araclar();
            arc.AracID = 4;
            arc.Marka = "Hyundai";
            arc.Model = "Palisade";
            arc.SirketID = 1;
            arc.EhliyetYasi = 20;
            arc.MinYasSiniri = 18;
            arc.GunukKm = 200;
            arc.AnlikKm = 500;
            arc.Airbag = 1;
            arc.BagajHacmi = 20000;
            arc.KoltukSayisi = 6;
            arc.GunlukKiralikFiyati = 120;
            arc.Durum = true;

            AraclarDTO dto = arc.MapTo<AraclarDTO>();

        }
    }
}
