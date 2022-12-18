using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem222Batch
{
    public interface IContacts
    {
        public void AddContact(String firstName, String lastName, String address, String city, String state, String zip, String phoneNumber, String email);
        public void EditContact(string firstName);
        public void DeleteContact(string firstName);
        public void DisplayContact();
    }
}
