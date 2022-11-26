using System;
using System.Linq.Expressions;

namespace AddressBookSystem222Batch
{
    public class Program
    {

        static void Main(string[] args)
        {
            //Welcome message uc1
            Console.WriteLine("Welcome to Address Book");
            Console.WriteLine("Able to create a contact list ");
            //created a Contacts class
            
            //Creating the object of AddressBookBuilder class and calling its methods
            AddressBookBuilder builder = new AddressBookBuilder();
            ////add contacts
            builder.AddContacts();
            ////display contacts
            builder.DisplayContact();
            //edit contact
            builder.EditExistingContact();
            ////after editing display contact
            builder.DisplayContact();
            ////delet existing contact
            builder.DeleteExistingContact();
            ////after deleting display contact
            builder.DisplayContact();
        }
    }
}
