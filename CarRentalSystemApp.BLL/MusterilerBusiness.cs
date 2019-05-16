using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSystemApp.DAL2;
using CarRentalSystemApp.Models;
using System.Security.Authentication;

namespace CarRentalSystemApp.BLL
{
    public class MusterilerBusiness :GenericBusiness<Musteriler>
    {
        public static Musteriler UserMusteriLogin(Musteriler modelUser)
        {
            if (string.IsNullOrEmpty(Convert.ToString(modelUser.KullaniciAdi)) && string.IsNullOrEmpty(modelUser.Sifre))
            {
                throw new AuthenticationException("Kullanici Verileri Boş Geçilemez !");
            }
            using(var context = new CarRentalAppContext())
            {
                var result = context.Musteriler.FirstOrDefault(x => x.KullaniciAdi == modelUser.KullaniciAdi && x.Sifre == modelUser.Sifre);
                if (result == null)
                {
                    throw new AuthenticationException("Kullanıcı Girişi Başarısız !");
                }
                return result;
            }
        }
        
    }
}
