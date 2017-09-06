using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;
using WcfDbService.Interfaces;

namespace WcfDbService.Emplements
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Single)]
    public class ServerCallback : IServerCallback
    {
        [DataMember]
        IServerCallback callback;

        public ServerCallback(IServerCallback callback)
        {
            this.callback = callback;
        }

        public void SendInfo(string info)
        {
            callback.SendInfo(info);
        }
    }
}