using CarRentalSystemApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CarRentalSystemApp.WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalisanlarService" in both code and config file together.
    [ServiceContract]
    public interface ICalisanlarService : IServiceBase<CalisanlarDTO>
    {

    }
}
