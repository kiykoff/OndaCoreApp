using InventOnHandDimService;
using SalesSalesOrderService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace OndaCore.Models
{
    public class AxaptaModel
    {
        public static string[] RunserviceOnHandAsync()
        {
            //string itemid;
            string[] array = new string[40];

            InventOnHandDimService.QueryCriteria query = new InventOnHandDimService.QueryCriteria();
            InventOnHandDimService.CriteriaElement[] element = { new InventOnHandDimService.CriteriaElement() };

            InventOnHandDimService.EntityKey[] entityKey = { new InventOnHandDimService.EntityKey() };

            element[0].DataSourceName = "InventSum";
            element[0].FieldName = "ItemId";
            element[0].Operator = InventOnHandDimService.Operator.Equal;
            element[0].Value1 = "001009";

            query.CriteriaElement = element;


            entityKey = Find(query).Result.EntityKeyList;

            if (entityKey != null)
            {
                //itemid = entityKey.First().KeyData[1].Value;
                for (int i = 0; i <= entityKey.Length - 1; i++)
                {
                    array[i] = entityKey[i].KeyData[1].Value;
                }
                return array;
            }
            else
            {
                //itemid = "чота не нашлось";
                return null;
            }

            //            return itemid;

        }

        public static async Task<InventOnhandDimServiceFindKeysResponse> Find(InventOnHandDimService.QueryCriteria queryCriteria)
        {
            InventOnhandDimServiceClient client = new InventOnhandDimServiceClient();
            return await client.findKeysAsync(queryCriteria);
        }


        public static string Create()
            {
                AxdEntity_SalesLine line =new AxdEntity_SalesLine();
                AxdEntity_SalesTable table = new AxdEntity_SalesTable();
                AxdSalesOrder order = new AxdSalesOrder();
                SalesSalesOrderService.AxdEntity_InventDim inventDim = new SalesSalesOrderService.AxdEntity_InventDim();
                SalesSalesOrderService.EntityKey[] keys = { new SalesSalesOrderService.EntityKey() }; 

                inventDim.InventSiteId = "001";

                line.ItemId = "001002";
                line.SalesQty = 42;
                line.SalesUnit = "шт.";
                line.InventDim = new SalesSalesOrderService.AxdEntity_InventDim[] { inventDim };

            table.CustAccount = "000138";
                table.PurchOrderFormNum = "xyz";
                table.ReceiptDateRequested = DateTime.Now.Date;
                table.SalesLine = new AxdEntity_SalesLine[] { line };

            order.SalesTable = new AxdEntity_SalesTable[] { table };

            keys = Call(order).Result.EntityKeyList;

            return keys[0].KeyData[0].Value;
            
            }

        public static async Task<SalesOrderServiceCreateResponse> Call(AxdSalesOrder order)
        {

            SalesOrderServiceClient client = new SalesOrderServiceClient();
            AppContext.SetSwitch("System.Net.Http.UseSocketsHttpHandler", false);
            return await client.createAsync(order);
        }

    }

}
