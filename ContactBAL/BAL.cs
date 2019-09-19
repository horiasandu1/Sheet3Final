using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;
using ContactDAL;
using Entities;

namespace ContactBAL
{
    public class BAL
    {
        public void AddContact(Contact c)
        {
            c.ID = DB.lastId++;
            DB.contacts.Add(c);
        }

        public List<Contact> GetContacts()
        {
            return DB.contacts;
        }

        public Contact RetrieveContact(int i)
        {
            return DB.contacts.Where(x => x.ID == i).Single();
        }

        public void Delete(int id)
        {
            var contact = RetrieveContact(id);
            contact.active = false;
        }



        public void updateContact(Contact c)
        {
            Contact updateTarget = DB.contacts.Where(x => x.ID == c.ID).First();
            updateTarget.firstName = c.firstName;
            updateTarget.lastName = c.lastName;
            updateTarget.cellPhone = c.cellPhone;
            updateTarget.businessPhone = c.businessPhone;
            updateTarget.homePhone = c.homePhone;
            updateTarget.address = c.address;
            updateTarget.active = c.active;
            updateTarget.notes = c.notes;
        }


    }
}
