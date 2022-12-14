using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;

namespace AddressBookSystem222Batch
{
     public class Program
    {
        static void Main(string[] args)
        {
            //Welcome message uc1
            Console.WriteLine("Welcome to Address Book");

            /// <summary>
            /// Dictionary is used to store multiple contact lists 
            /// key= first name , value=contact list
            /// </summary>
            Dictionary<string, List<Contact>> addressBookDictionary = new Dictionary<string, List<Contact>>();
            /// <summary>
            /// adding cotact lists to dictionary
            /// </summary>

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter how many address books you want to add");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine("enter name of {0} address book ", i);
                        string name = Console.ReadLine();
                        addressBookDictionary.Add(name, new List<Contact>());
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("Name is invamlid or Duplicate");
                }
                break;
            }
            ///<summary>
            ///Displaying names of address books
            /// </summary>
            while (true)
            {
                Console.WriteLine("List of address books :");
                foreach(var key in addressBookDictionary.Keys)
                {
                    Console.WriteLine(key);
                }

                //choose address book where you want to add contacts
                tryAgain:
                Console.WriteLine("Enter the Adress book name where you want to add contact");
                string addContactInAdressBook = Console.ReadLine();
                if (addressBookDictionary.ContainsKey(addContactInAdressBook))
                {
                    //Creating the object of AddressBookBuilder class and calling its methods
                    AddressBookBuilder builder = new AddressBookBuilder();
                    ////add contacts
                    builder.AddContacts();
                    ////display contacts
                    builder.DisplayContact();
                    Console.WriteLine("choose option\n1:Edit contact\n2:delete contact");
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            //edit contact
                            builder.EditExistingContact();
                            ////after editing display contact
                            builder.DisplayContact();
                            break;
                        case 2:
                            ////delet existing contact
                            builder.DeleteExistingContact();
                            ////after deleting display contact
                            builder.DisplayContact();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("This name of address book is not found , please enter a valid name");
                    goto tryAgain;
                }
                break;
            }
        }
    }
}
