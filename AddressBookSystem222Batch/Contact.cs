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
        public String FirstName;
        public String LastName;
        public String Address;
        public String City;
        public String State;
        public String Zip;
        public String PhoneNum;
        public String Email;
        //consstructor
        public Contact(String firstName, String lastName, String address, String city, String state, String zip, String phone, String email)
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
