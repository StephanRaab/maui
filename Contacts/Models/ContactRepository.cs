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
            new Contact{Name="John Doe", Email="John.Doe@email.com" },
            new Contact{Name="Jane Doe", Email="Jane.Doe@email.com" },
            new Contact{Name="J D", Email="J.D@email.com" },
            new Contact{Name="Hank Green", Email="HG@email.com" },
        };

        public static List<Contact> GetAllContacts() => contacts;

        public static Contact GetContactById(int contactId) {
            return contacts.FirstOrDefault(x => x.ContactId == contactId);
        }
    }
}
