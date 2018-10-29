using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PBA;

namespace OndaCore.Models
{
    public class PBAModel
    {




        public static string Test()
        {
            string str;
            PBAWebServiceClient client = new PBAWebServiceClient();

            str = client.testAsync().Result.response;

            client.Close();

            return str;

        }
    }
}
