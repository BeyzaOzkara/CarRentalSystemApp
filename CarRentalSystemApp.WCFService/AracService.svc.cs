using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CarRentalSystemApp.DTO;


namespace CarRentalSystemApp.WCFService
{
    using Models;
    using Extensions;
    using DAL2.Repositories.Concretes;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AracService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AracService.svc or AracService.svc.cs at the Solution Explorer and start debugging.
    public class AracService : ServiceBase<AraclarRepository, Araclar, AraclarDTO>, IAracService
    {

    }
}
