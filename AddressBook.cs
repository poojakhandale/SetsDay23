using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day23Sets
{
    public class AddressBook
    {
        public List<Contacts> ContactInfo { get; set; }
        public Dictionary<string, List<Contacts>> ContactsByCountry { get; set; }

        public AddressBook()
        {
            ContactInfo = new List<Contacts>();
            ContactsByCountry = new Dictionary<string, List<Contacts>>();
        }

        public void AddContact(Contacts contact)
        {
            if (!ContactInfo.Contains(contact))
            {
                ContactInfo.Add(contact);

                if (!ContactsByCountry.ContainsKey(contact.country))
                {
                    ContactsByCountry[contact.country] = new List<Contacts>();
                }
                ContactsByCountry[contact.country].Add(contact);
            }
        }

        public void PrintContacts()
        {
            foreach (var contact in ContactInfo)
            {
                Console.WriteLine("Name: {0} {1}\nCountry: {2}\nPhone: {3}\nEmail: {4}\n",
                    contact.firstName, contact.lastName, contact.country, contact.phoneNumber, contact.email);
            }
        }

        public List<Contacts> GetContactsByCountry(string country)
        {
            return ContactsByCountry.ContainsKey(country) ? ContactsByCountry[country] : new List<Contacts>();
        }

        public void PrintContactCountByCountry()
        {
            Console.WriteLine("Contact Count By Country:");

            foreach (var kvp in ContactsByCountry)
            {
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value.Count);
            }
        }
    }
}


