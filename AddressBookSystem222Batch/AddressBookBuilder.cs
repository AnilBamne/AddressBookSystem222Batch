using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookSystem222Batch
{
    /// <summary>
    /// Creating a AdressBookBuilder class ,which is inheriting IContacts interface 
    /// </summary>
    public class AdressBookBuilder : IContacts
    {
        /// <summary>
        /// Creating a list of contacts
        /// </summary>
        public List<Contact> contactList;

        /// <summary>
        /// Constructor,Initializing the list 
        /// </summary>
        public AdressBookBuilder()
        {
            this.contactList = new List<Contact>();
        }

        /// <summary>
        /// AddContact method is used to add contacts to the list
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        public void AddContact(String firstName, String lastName, String address, String city, String state, String zip, String phoneNumber, String email)
        {
            bool duplicate = Equals(firstName);
            if (!duplicate)
            {
                Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
                contactList.Add(contact);
            }
            else
            {
                Console.WriteLine("Cannot add duplicate contacts first name");
            }
        }

        /// <summary>
        /// Overriding the Equals method to find the duplicate contacts
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        private bool Equals(string firstName)
        {
            if (this.contactList.Any(e => e.firstName == firstName))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Editing the contacts by passing parameter as first name 
        /// </summary>
        /// <param name="firstName"></param>
        public void EditContact(string firstName)
        {
            int flag = 1;
            foreach (Contact contact in contactList)
            {
                if (firstName.Equals(contact.firstName))
                {
                    flag = 0;
                    Console.WriteLine("Please select the area of editing \n" +
                        "1)First Name\n2)Last Name\n3)Address\n4)Phone Number\n5)Email_Id");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Please enter your first name : ");
                            contact.firstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Please enter your last name : ");
                            contact.lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Please enter your Address : ");
                            contact.address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Please enter your Phone Number : ");
                            contact.phoneNumber = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Please enter your email Id: ");
                            contact.email = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Entered an Invalid input\n try again");
                            break;
                    }
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Contact not found");
            }
        }

        /// <summary>
        /// Deleting the contact of the person
        /// </summary>
        /// <param name="firstName"></param>
        public void DeleteContact(string firstName)
        {
            int flag = 1;
            foreach (Contact contact in contactList)
            {
                if (firstName.Equals(contact.firstName))
                {
                    flag = 0;
                    contactList.Remove(contact);
                    Console.WriteLine("Sucessfully deleted");
                    break;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Contact not found");
            }
        }

        /// <summary>
        /// Displaying the contacts
        /// </summary>
        public void DisplayContact()
        {
            foreach (Contact contact in contactList)
            {
                Console.WriteLine("\nFirst name = " + contact.firstName);
                Console.WriteLine("Last name = " + contact.lastName);
                Console.WriteLine("Address = " + contact.address);
                Console.WriteLine("city = " + contact.city);
                Console.WriteLine("state = " + contact.state);
                Console.WriteLine("zip = " + contact.zip);
                Console.WriteLine("phoneNumber = " + contact.phoneNumber);
                Console.WriteLine("email = " + contact.email);
            }
        }

        /// <summary>
        /// searching the list of persons in a perticular City and state
        /// </summary>
        /// <param name="place"> the city or the state </param>
        /// <returns></returns>
        public List<string> FindPerson(string place)
        {
            List<string> personFound = new List<string>();
            foreach(Contact contact in contactList.FindAll(e => (e.city.Equals(place))).ToList())
            {
                string name=contact.firstName+" "+contact.lastName;
                personFound.Add(name);
            }
            if(personFound.Count == 0)
            {
                foreach (Contact contact in contactList.FindAll(e => (e.state.Equals(place))).ToList())
                {
                    string name = contact.firstName + " " + contact.lastName;
                    personFound.Add(name);
                }
            }
            return personFound;
        }
    }
}



