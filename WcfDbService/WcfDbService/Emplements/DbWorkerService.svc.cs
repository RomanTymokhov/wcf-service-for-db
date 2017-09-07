using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfDbService.DbLayer;
using WcfDbService.Interfaces;

namespace WcfDbService
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true, ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]
    public class DbWorkerService : IDbWorkerService
    {
        SqlDbProvider sqlDb;

        public void CreateIdemAcount(string email, string phone)
        {
            sqlDb = new SqlDbProvider();
            sqlDb.CreateIdemAcount(email, phone);

            //chek callback working
            var serverCalback = OperationContext.Current.GetCallbackChannel<IServerCallback>();
            serverCalback.SendInfo("idmUser Creating");
        }
    }
}
