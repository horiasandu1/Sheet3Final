using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Contact
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string cellPhone { get; set; }
        public string homePhone { get; set; }
        public string businessPhone { get; set; }
        public string address { get; set; }
        public string notes { get; set; }

        public Boolean active { get; set; }
    }
}
