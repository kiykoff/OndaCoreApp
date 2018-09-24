using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactPersonsSrv;

namespace OndaCore.Models
{
    public class ContactPersonModel
    {
       public struct PersonInfo
        {
            public string CellularPhone;
            public string Email;
            public string PhoneLocal;
            
        }


        public PersonInfo FindContactInfo (string _partyId)
        {

            QueryCriteria queryCriteria = new QueryCriteria();
            CriteriaElement[] criteria = { new CriteriaElement() };
            AxdEntity_ContactPerson[] persons = { new AxdEntity_ContactPerson() };
            string partyId = _partyId;
            PersonInfo PersonInfo = new PersonInfo();



            criteria[0].DataSourceName = "ContactPerson";
            criteria[0].FieldName = "PartyId";
            criteria[0].Operator = Operator.Equal;
            criteria[0].Value1 = partyId;

            queryCriteria.CriteriaElement = criteria;
            ContactPersonsServiceClient client = new ContactPersonsServiceClient();

            try
            {
                persons = client.findAsync(queryCriteria).Result.ContactPersons.ContactPerson;
                client.CloseAsync();
            }
            catch (Exception)
            {
                client.Abort();
                throw;
            }
            if (persons != null)
            {
                foreach (AxdEntity_ContactPerson a in persons)
                {
                    PersonInfo.CellularPhone = a.CellularPhone;
                    PersonInfo.Email = a.Email;
                    PersonInfo.PhoneLocal = a.PhoneLocal;

                }
            }
            
            
            return PersonInfo;


        }

    }
}
