using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GalleryStructService;

namespace OndaCore.Models
{
    public class ImageGalleryModel
    {
        public AxdWebGalleryStruct GetProductStruct ()
        {
            QueryCriteria queryCriteria = new QueryCriteria();
            CriteriaElement[] criteria = { new CriteriaElement() };
            AxdWebGalleryStruct structure = new AxdWebGalleryStruct();

            criteria[0].DataSourceName = "InventProductGroup";
            criteria[0].FieldName = "ProductGroupId";
            criteria[0].Operator = Operator.NotEqual;
            criteria[0].Value1 = "";

            queryCriteria.CriteriaElement = criteria;
            WebGalleryStructServiceClient client = new WebGalleryStructServiceClient();

            try
            {
                structure = client.findAsync(queryCriteria).Result.WebGalleryStruct;
                client.CloseAsync();
            }

            catch (Exception)
            {
                client.Abort();
                throw;
            }

            return structure;
        }

    }
}
