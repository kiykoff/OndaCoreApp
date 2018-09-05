using InventOnHandDimService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OndaCore.Models
{
    public class AxaptaModel
    {
        public static string RunserviceOnHandAsync()
        {
            string itemid;


            QueryCriteria query = new QueryCriteria();
            CriteriaElement[] element = { new CriteriaElement() };

            EntityKey[] entityKey = { new EntityKey() };

            element[0].DataSourceName = "InventSum";
            element[0].FieldName = "ItemId";
            element[0].Operator = Operator.Equal;
            element[0].Value1 = "001009";

            query.CriteriaElement = element;


            //entityKey = await client.findKeysAsync(query);

            entityKey = Find(query).Result.EntityKeyList;

            if (entityKey != null)
            {
                itemid = entityKey.First().KeyData[1].Value;
            }
            else
            {
                itemid = "чота не нашлось";
            }
            
            return itemid;

        }

        public static async Task<InventOnhandDimServiceFindKeysResponse> Find(QueryCriteria queryCriteria)
        {

            InventOnhandDimServiceClient client = new InventOnhandDimServiceClient();
            
            return await client.findKeysAsync(queryCriteria);

                       
        }
    }

}
