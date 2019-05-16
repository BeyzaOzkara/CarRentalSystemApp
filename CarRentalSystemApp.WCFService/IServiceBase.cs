using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace CarRentalSystemApp.WCFService
{
    [ServiceContract]
    //servis olarak karşı tarafa bunu miras alan sınıfların/interfacelerin başka projelerde servis olarak kullanılabilmesini sağlar
    public interface IServiceBase<T>
    {
        [OperationContract]
        List<T> Listele();
        [OperationContract]
        bool Ekle(T entity);
        [OperationContract]
        bool Güncelle(T entity);
        [OperationContract]
        bool Sil(T entity);
        [OperationContract]
        T GetById(int id);
        [OperationContract]
        bool DeleteById(int id);

    }
}
