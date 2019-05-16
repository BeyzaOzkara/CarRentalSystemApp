using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystemApp.Extensions
{
    public static class TypeExtensions
    {
        public static T MapTo<T>(this object source)
        {
            Type hedeftip = typeof(T);
            Type kaynaktip = source.GetType();
            T sonuc = Activator.CreateInstance<T>();

            PropertyInfo[] hedefozellikler = hedeftip.GetProperties();
            PropertyInfo[] kaynakozellikler = kaynaktip.GetProperties();

            foreach(PropertyInfo ko in kaynakozellikler)
            {
                PropertyInfo ho = hedefozellikler.FirstOrDefault(x => x.Name.ToLower() == ko.Name.ToLower());
                //kısaca aktarmaya çalıştığım yerde o isimde bi şey var mı diye bakıyoum??
                if (ho != null)
                {
                    object veri = ko.GetValue(source);
                    //sourcedan git o özelliği bul o özelliğin değerini getir
                    ho.SetValue(sonuc, veri);

                }

            }
            return sonuc;

        }

    }
}
