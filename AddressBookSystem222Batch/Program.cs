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
            Console.WriteLine("Welcome To  Book System!");
            ///<summary>
            ///Creating a dictionary to store the multiple addressbooks
            /// </summary>
            Dictionary<string, AdressBookBuilder> adressBookDictionary = new Dictionary<string, AdressBookBuilder>();

            //creating the multiple address books 
            while (true)
            {
                try
                {
                    Console.WriteLine("How many adress book you want = ");
                    int numOfAdressBook = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= numOfAdressBook; i++)
                    {
                        Console.WriteLine("Enter the name of adress book = " + i + "=");
                        String adressBookName = Console.ReadLine();
                        AdressBookBuilder adressBookBuilder = new AdressBookBuilder();
                        adressBookDictionary.Add(adressBookName, adressBookBuilder);
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter integer number,\n string is not allowes \n enter unique name for book \n duplicate name not allowed");
                }
            }

            while (true)
            {
                try
                {
                    //Printing addressbook names
                    Console.WriteLine("You have created following adress book");
                    foreach (string k in adressBookDictionary.Keys)
                    {
                        Console.WriteLine(k);
                    }

                    //Using switch case to add,edit,delete and display contacts
                    Console.WriteLine("\n 1 for Add Contact \n 2 for Edit Existing Contact \n 3 for delete the person,\n 4 for display,\n 5 Search person in city or state\n 7 for exit");
                    int choise = Convert.ToInt32(Console.ReadLine());
                    switch (choise)
                    {
                        case 1:
                            Console.WriteLine("Enter the Adress book name where you want to add contact");
                            string addContactInAdressBook = Console.ReadLine();
                            if (adressBookDictionary.ContainsKey(addContactInAdressBook))
                            {
                                Console.WriteLine("Enter how many contact you want to add");
                                int numOfContact = Convert.ToInt32(Console.ReadLine());
                                for (int i = 1; i <= numOfContact; i++)
                                {
                                    TakeInputAndAddToContact(adressBookDictionary[addContactInAdressBook]);
                                }
                                adressBookDictionary[addContactInAdressBook].DisplayContact();
                            }
                            else
                            {
                                Console.WriteLine("No adress book found ", addContactInAdressBook);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Enter the Adress book name where you want to edit contact = ");
                            string editContactInAdressBook = Console.ReadLine();
                            if (adressBookDictionary.ContainsKey(editContactInAdressBook))
                            {
                                Console.WriteLine("Enter first name to edit contact =");
                                String firstNameForEditContact = Console.ReadLine();
                                adressBookDictionary[editContactInAdressBook].EditContact(firstNameForEditContact);
                                adressBookDictionary[editContactInAdressBook].DisplayContact();
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter the Adress book name where you want to delete contact = ");
                            string deleteContactInAdressBook = Console.ReadLine();
                            if (adressBookDictionary.ContainsKey(deleteContactInAdressBook))
                            {
                                Console.WriteLine("Enter first name to delete contact =");
                                String firstNameForDeleteContact = Console.ReadLine();
                                adressBookDictionary[deleteContactInAdressBook].DeleteContact(firstNameForDeleteContact);
                                adressBookDictionary[deleteContactInAdressBook].DisplayContact();
                            }
                            break;
                        case 4:
                            Console.WriteLine("Enter the Adress book name to display contact = ");
                            String displayContactInAdressBook = Console.ReadLine();
                            adressBookDictionary[displayContactInAdressBook].DisplayContact();
                            break;
                        case 5:
                            FindPersonByCityOrState(adressBookDictionary);
                            break;
                        case 6:
                            break;
                        case 7:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Enter The Valid Choise");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("please enter integer options only");
                }
            }
        }
        /// <summary>
        /// TakeInputAndAddToContact method takes user input and sends to add method in the address book builder
        /// </summary>
        /// <param name="adressBookBuilder"></param>
        public static void TakeInputAndAddToContact(AdressBookBuilder adressBookBuilder)
        {
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
            adressBookBuilder.AddContact(firstName, lastName, address, city, state, zip, phoneNumber, email);
        }

        /// <summary>
        /// Finding the person by the city name or state name
        /// </summary>
        /// <param name="adressBookBuilder"> dictonary of addresss books </param>
        public static void FindPersonByCityOrState(Dictionary<string,AdressBookBuilder> adressBookBuilder)
        {
            Console.WriteLine("Enter the city or state where you want to find that person = ");
            string findPlace = Console.ReadLine();
            foreach(var element in adressBookBuilder)
            {
                List<string> listOfPersonFoundInPlace = element.Value.FindPerson(findPlace);
                if(listOfPersonFoundInPlace.Count==0)
                {
                    Console.WriteLine("No person in that city/state of adress book  = " + element.Key);
                }
                else
                {
                    Console.WriteLine("The person in that city/state of adress book = " + element.Key + " = ");
                    foreach(var person in listOfPersonFoundInPlace)
                    {
                        Console.WriteLine(person);
                    }
                }
            }
        }
    }
}
