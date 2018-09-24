using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PartyTableCustom;




namespace OndaCore.Models
{
    public class EmplModel 
    {
        public struct Employee
        {
            public string name;
            public string title;
            public string calendar;
            public string CellularPhone;
            public string Email;
            public string PhoneLocal;
            public string FileName;
            public string FileType;
        }

        
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
             criteria[0].FieldName = "ReqAttention";
             criteria[0].Operator = Operator.Equal;
             criteria[0].Value1 = "site";

            queryCriteria.CriteriaElement = criteria;

            DirPartyTableCustomServiceClient client = new DirPartyTableCustomServiceClient();

            table = client.findAsync(queryCriteria).Result.DirPartyTableCustom;

             client.CloseAsync();

             return table;

         }

        public Employee[] FindPersonsContactInfo ()
        {
            ContactPersonModel.PersonInfo Contacts = new ContactPersonModel.PersonInfo();
            Employee[] Employee  = new Employee [20];
            List<string> Info = new List<string>();
            QueryCriteria queryCriteria = new QueryCriteria();
            CriteriaElement[] criteria = { new CriteriaElement() };

            int i = 0;

            AxdDirPartyTableCustom table = new AxdDirPartyTableCustom();

             criteria[0].DataSourceName = "EmplTable";
             criteria[0].FieldName = "ReqAttention";
             criteria[0].Operator = Operator.Equal;
             criteria[0].Value1 = "site";

            queryCriteria.CriteriaElement = criteria;

            DirPartyTableCustomServiceClient client = new DirPartyTableCustomServiceClient();
            try
            {
                table = client.findAsync(queryCriteria).Result.DirPartyTableCustom;
                client.CloseAsync();
            } 
            catch (Exception)
            {
                client.Abort();
                throw;
            }

            ContactPersonModel ContactPersonModel = new ContactPersonModel();
            
            
            foreach (AxdEntity_DirPartyTable a in table.DirPartyTable)
            {
                Contacts = ContactPersonModel.FindContactInfo(a.PartyId);

                Employee[i].name = a.Name;
                Employee[i].title = a.EmplTable[0].Title;
                Employee[i].calendar = a.EmplTable[0].CalendarId;
                Employee[i].CellularPhone = Contacts.CellularPhone;
                Employee[i].Email = Contacts.Email;
                Employee[i].PhoneLocal = Contacts.PhoneLocal;
                Employee[i].FileName = a.EmplTable[0].DocuRef[0].DocuValue[0].FileName;
                Employee[i].FileType = a.EmplTable[0].DocuRef[0].DocuValue[0].FileType;

                i++;
            }

            return Employee;



        } 
    }
}
