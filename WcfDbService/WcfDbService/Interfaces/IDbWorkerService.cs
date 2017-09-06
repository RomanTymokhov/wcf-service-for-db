using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfDbService.Interfaces
{
    [ServiceContract(CallbackContract = typeof(IServerCallback))]
    public interface IDbWorkerService
    {
        [OperationContract(IsOneWay = true)]
        void CreateIdemAcount(string email, string phone);

        // TODO: Добавьте здесь операции служб
    }    
}
