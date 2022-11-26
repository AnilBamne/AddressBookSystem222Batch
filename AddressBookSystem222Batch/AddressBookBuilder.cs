using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookSystem222Batch
{
    class AddressBookBuilder
    {
        //Creating a list of contacts globally
        public List<Contact> ContactsList;
        //Constructor
        //Initializing the contacts list 
        public AddressBookBuilder()
        {
            this.ContactsList = new List<Contact>();
        }
        //Method for adding contacts to list by taking input from user
        public void AddContacts(String firstName, String lastName, String address, String city, String state, String zip, String phone, String email)
        {
            Contact contact = new Contact(firstName, lastName, address, city, state, zip, phone, email);
            this.ContactsList.Add(contact);
        }
        //DisplayContact method used for displaying contact list
        public void DisplayContact()
        {
            Console.WriteLine("----  Displaying Contacts ----\n");
            foreach(Contact contact in this.ContactsList)
            {
                Console.WriteLine("First Name = "+contact.FirstName);
                Console.WriteLine("Last Name = "+contact.LastName);
                Console.WriteLine("Address = "+contact.Address);
                Console.WriteLine("City  = "+contact.City);
                Console.WriteLine("State = "+contact.State);
                Console.WriteLine("Zip code  = "+contact.Zip);
                Console.WriteLine("Phone number  = "+contact.PhoneNum);
                Console.WriteLine("Email ID  = "+contact.Email);
            }
        }
        //EditExistingContact method used for editin the existing contact details
        public void EditExistingContact()
        {
            search:
            Console.WriteLine("\nEnter first name of the person for editing contact");
            String firstname=Console.ReadLine();
            foreach( Contact contact in this.ContactsList)      //Iterating contacts iin list
            {
                //Checking the existatnce of the person name in contact list
                if (contact.FirstName == firstname)
                {
                    ReCheck:
                    Console.WriteLine("Please select the area of editing \n" +
                        "1)First Name\n2)Last Name\n3)Address\n4)Phone Number\n5)Email_Id");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Please enter your first name : ");
                            contact.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Please enter your last name : ");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Please enter your Address : ");
                            contact.Address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Please enter your Phone Number : ");
                            contact.PhoneNum = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Please enter your email Id: ");
                            contact.Email = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Entered an Invalid input\n try again");
                            goto ReCheck;
                    }
                    Console.WriteLine("Contact edited succesfully");
                }
                else
                {
                    Console.WriteLine("*** Wrong Input ***: please enter a valid First name");
                    goto search; 
                }
            }
        }
    }
}
