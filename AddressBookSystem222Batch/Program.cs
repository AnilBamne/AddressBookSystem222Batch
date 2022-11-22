using System;

namespace AddressBookSystem222Batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome message uc1
            Console.WriteLine("Welcome to Address Book");
            Console.WriteLine("Enter the use case to execute\n1:Ability to create a contact\n2:Add a new contact to Address book\n3:Ability to Edit existing condtact\n4:Ability to Delete contact using person's name\n");
            int option =Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Able to create a contact list ");
                    //created a Contacts class
                    break;
                case 2:
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
                    builder.AddContacts(firstName,lastName,address,city,state,zip,phoneNumber,email);
                    //display contacts
                    Console.WriteLine("\n************** Contact Details are ************");
                    builder.DisplayContact();

                    break;
                case 3:
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }
    }
}
