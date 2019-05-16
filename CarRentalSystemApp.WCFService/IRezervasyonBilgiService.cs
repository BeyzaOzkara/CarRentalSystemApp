using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CarRentalSystemApp.DTO;

namespace CarRentalSystemApp.WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRezervasyonBilgiService" in both code and config file together.
    [ServiceContract]
    public interface IRezervasyonBilgiService : IServiceBase<RezervasyonBilgiDTO>
    {

    }
}
