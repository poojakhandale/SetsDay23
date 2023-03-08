// See https://aka.ms/new-console-template for more information
using SetsDay23;

namespace Day23Sets
{
    class Program
    {
        public static void Main(string[] args)
        {
            AddressBook myAddressBook = new AddressBook();
            Contacts newContact = new Contacts("Pooja", "khandale", "INDIA", "8369319177", "pooja.p@example.com");
            Contacts newContact2 = new Contacts("Rani", "Dube", "USA", "888222444", "rani.dube@jr.com");
            Contacts newContact3 = new Contacts("preeti", "sharma", "USA", "888222444", "rani.dube@jr.com");

            myAddressBook.AddContact(newContact);
            myAddressBook.AddContact(newContact2);
            myAddressBook.AddContact(newContact3);
            myAddressBook.SearchByCountry("USA");
            //myAddressBook.PrintContacts();
        }
    }
}