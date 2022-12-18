using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem222Batch
{
    /// <summary>
    /// Created a Contact class,Which store person details
    /// </summary>
    public class Contact
    {
        public String firstName;
        public String lastName;
        public String address;
        public String city;
        public String state;
        public String zip;
        public String phoneNumber;
        public String email;

        /// <summary>
        /// constructor to initialize the parameters
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        public Contact(String firstName, String lastName, String address, String city, String state, String zip, String phoneNumber, String email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        /// <summary>
        /// overriding the ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "first Name=" + firstName + ",last name=" + lastName + ",address="
            + address + ",city=" + city + ",state=" + state + ",zip" +
            zip + ",phone number=" + phoneNumber + "email=" + email;
        }
    }
}
