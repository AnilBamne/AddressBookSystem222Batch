using System;
using System.Linq.Expressions;

namespace AddressBookSystem222Batch
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Welcome message uc1
            Console.WriteLine("Welcome to Address Book");
            Console.WriteLine("Able to create a contact list ");
            //created a Contacts class
            Console.WriteLine("Enter first name = ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name = ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter address= ");
            String address = Console.ReadLine();
            Console.WriteLine("Enter city= ");
            String city = Console.ReadLine();
            Console.WriteLine("Enter state= ");
            String state = Console.ReadLine();
            Console.WriteLine("Enter zip= ");
            String zip = Console.ReadLine();
            Console.WriteLine("Enter phoneNumber= ");
            String phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter email= ");
            String email = Console.ReadLine();
            //Creating the object of AddressBookBuilder class and calling its methods
            AddressBookBuilder builder = new AddressBookBuilder();
            //add contacts
            builder.AddContacts(firstName, lastName, address, city, state, zip, phoneNumber, email);
            //display contacts
            builder.DisplayContact();
            builder.EditExistingContact();
            builder.DisplayContact();
        }
    }
}
