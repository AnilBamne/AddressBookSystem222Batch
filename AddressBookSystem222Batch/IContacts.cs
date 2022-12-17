using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem222Batch
{
    public interface IContacts
    {
        public void addContact(String firstName, String lastName, String address, String city, String state, String zip, String phoneNumber, String email);
        public void editContact(string firstName);
        public void deleteContact(string firstName);
        public void displayContact();
    }
}
