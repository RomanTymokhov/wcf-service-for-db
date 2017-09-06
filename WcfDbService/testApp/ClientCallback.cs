using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using testApp.IdemDbService;
using WcfDbService.Interfaces;

namespace testApp
{
    class ClientCallback:IDbWorkerServiceCallback
    {
        public event Action<string> InfoSended;

        public void SendInfo(string info)
        {
            if (InfoSended != null) InfoSended(info);
        }
    }
}