using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekChat.Shared
{
    public  class Contact
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Contact()
        {

        }
        public Contact(int contactId, string firstName, string lastName)
        {
            this.ContactId = contactId;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
