using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GalleryStructService;

namespace OndaCore.Models
{
    public class ImageGalleryModel
    {

        public AxdEntity_InventProductGroup GetProductStruct(string area = "")
        {
            QueryCriteria queryCriteria = new QueryCriteria();
            CriteriaElement[] criteria = { new CriteriaElement()};
            AxdWebGalleryStruct structure = new AxdWebGalleryStruct();

            AxdEntity_InventProductGroup ProductGroup = new AxdEntity_InventProductGroup();

            string range = "";

                switch (area)
                {
                    case "Materials":
                        range = "Материалы";
                        break;
                    case "Products":
                        range = "Изделия";
                        break;
                    default:
                        break;
                }
              

            criteria[0].DataSourceName = "InventProductGroup";
            criteria[0].FieldName = "ProductGroupType";
            criteria[0].Operator = Operator.Equal;
            criteria[0].Value1 = "0";

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

            foreach(AxdEntity_InventProductGroup a in structure.InventProductGroup)
            {
                if (a.ProductGroupId == range)
                {
                    ProductGroup =  a;
                }
                else
                {
                    continue;
                }
                
            }

            return ProductGroup;

        }

        

    }
}
