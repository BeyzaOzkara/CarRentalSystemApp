using CarRentalSystemApp.DAL2.Repositories.Concretes;
using CarRentalSystemApp.DTO;
using CarRentalSystemApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CarRentalSystemApp.WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalisanlarService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CalisanlarService.svc or CalisanlarService.svc.cs at the Solution Explorer and start debugging.
    public class CalisanlarService : ServiceBase<CalisanlarRepository, Calisanlar, CalisanlarDTO>, ICalisanlarService
    {

    }
}
