using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using testApp.IdemDbService;

namespace testApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var callback = new ClientCallback();

            callback.InfoSended += info =>
            {
                Console.WriteLine(info);
            };

            DbWorkerServiceClient service = new DbWorkerServiceClient(new InstanceContext(callback));

            service.CreateIdemAcount("tohoff824", "380660785635");

            Console.Read();
        }
    }
}
