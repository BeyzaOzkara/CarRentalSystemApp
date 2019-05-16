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
    public class CalisanlarBusiness : GenericBusiness<Calisanlar>
    {
        public static Calisanlar UserAdminLogin(Calisanlar modelUser)
        {
            if (string.IsNullOrEmpty(Convert.ToString(modelUser.KullaniciAdi)) && string.IsNullOrEmpty(modelUser.Sifre))
            {
                throw new AuthenticationException("Kullanici Verileri Boş Geçilemez !");
            }
            using (var context = new CarRentalAppContext())
            {
                // context.Database.Connection.Open();
                var result = context.Calisanlar.FirstOrDefault(x => x.KullaniciAdi == modelUser.KullaniciAdi && x.Sifre == modelUser.Sifre);

                if (result == null)
                {
                    throw new AuthenticationException("Kullanıcı Girişi Başarısız !");
                }
                return result;
            }
        }

    }
}
