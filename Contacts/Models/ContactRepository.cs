using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Models
{
    public static class ContactRepository
    {
        public static List<Contact> contacts = new List<Contact>() {
            new Contact{ContactId= 0, Name="John Doe", Email="John.Doe@email.com", Phone="555-829-8394", Address="1243 New York, NY 2u34" },
            new Contact{ContactId= 1, Name="Jane Doe", Email="Jane.Doe@email.com", Phone="748-748-2342", Address="1243 Atlanta, GA 27383"  },
            new Contact{ContactId= 2, Name="J D", Email="J.D@email.com", Phone="938-029-7354", Address="7282 Indianapolis, IN 83930"  },
            new Contact{ContactId= 3, Name="Hank Green", Email="HG@email.com", Phone="317-898-9283", Address="342 Goose, VA 46205"  },
        };

        public static List<Contact> GetAllContacts() => contacts;

        public static Contact GetContactById(int contactId) {
            return contacts.FirstOrDefault(x => x.ContactId == contactId);
        }
    }
}
