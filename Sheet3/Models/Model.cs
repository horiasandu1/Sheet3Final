using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entities;
using System.Collections.Generic;
using ContactBAL;

namespace Sheet3.Models
{
    public class Model
    {
        private  BAL classObject = new BAL();

        public List <Contact> getList()
        {
            return classObject.GetContacts();
        }
        


    }
}