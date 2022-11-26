using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem222Batch
{
    public class Contact
    {
        //Defining variables globally
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public int Zip;
        public int PhoneNum;
        public string Email;
        //consstructor
        public Contact(string firstName, string lastName, string address, string city, string state, int zip, int phone, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.PhoneNum = phone;
            this.Email = email;
        }

        public String toString()
        {
            return "First Name = " + FirstName + " Last Name = " + LastName + "Address + " + Address + " City = " + City + " stste = " + State + "Zip = " + Zip + "Phone number = " + PhoneNum + " Email = " + Email;
        }
    }
}
