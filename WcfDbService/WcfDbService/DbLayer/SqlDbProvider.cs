using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfDbService.DbLayer
{
    public class SqlDbProvider
    {
        public async void CreateIdemAcount(string email, string phone)
        {
            try
            {
                using (IdemDatabaseEntities proxy = new IdemDatabaseEntities())
                {
                    var queryStr = "insert into IdemAcount(email, phone) values ('" + email + "','" + phone + "');";
                    proxy.Database.ExecuteSqlCommand(queryStr);
                    await proxy.SaveChangesAsync();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("{0} Exception caught.", err);
                //logged this
            }
        }
    }
}