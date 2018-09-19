using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PartyTableCustom;


namespace OndaCore.Models
{
    public class EmplModel 
    {
         public static EntityKey[] FindKeys ()
         {
             QueryCriteria query = new QueryCriteria();
             CriteriaElement[] criteria = { new CriteriaElement() };

             EntityKey[] employee = { new EntityKey() };

             criteria[0].DataSourceName = "EmplTable";
             criteria[0].FieldName = "ReqAttention";
             criteria[0].Operator = Operator.Equal;
             criteria[0].Value1 = "site";

             query.CriteriaElement = criteria;



             DirPartyTableCustomServiceClient client = new DirPartyTableCustomServiceClient();
             //AppContext.SetSwitch("System.Net.Http.UseSocketsHttpHandler", false);

             try
             {
                 employee = client.findKeysAsync(query).Result.EntityKeyList;
                 client.Close();
             } 
             catch(Exception)
             {
                 client.Abort();
                 throw;
             }

             return employee;

         }

        public static AxdDirPartyTableCustom Find ()
         {

            QueryCriteria queryCriteria = new QueryCriteria();
             CriteriaElement[] criteria = { new CriteriaElement() };

            AxdDirPartyTableCustom table = new AxdDirPartyTableCustom();

             criteria[0].DataSourceName = "EmplTable";
             criteria[0].FieldName = "EmplId";
             criteria[0].Operator = Operator.Equal;
             criteria[0].Value1 = "006";

            queryCriteria.CriteriaElement = criteria;

            DirPartyTableCustomServiceClient client = new DirPartyTableCustomServiceClient();

            table = client.findAsync(queryCriteria).Result.DirPartyTableCustom;

             client.CloseAsync();

             return table;

         } 
    }
}
