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
            Dictionary<string, AdressBookBuilder> adressBookDictionary = new Dictionary<string, AdressBookBuilder>();   //for address books
            Dictionary<string,List<string>> cityDictionary=new Dictionary<string, List<string>>();                      //For cities
            Dictionary<string,List<string>> stateDictionary=new Dictionary<string, List<string>>();                      //For states


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
                    Console.WriteLine("\nYou have created following adress books");
                    foreach (string k in adressBookDictionary.Keys)
                    {
                        Console.WriteLine(k);
                    }

                    //Using switch case to add,edit,delete and display contacts
                    Console.WriteLine("\n 1 for Add Contact \n 2 for Edit Existing Contact \n 3 for delete the person,\n 4 for display,\n 5 View person by city or state" +
                        "\n 6 Sort the entries Alphabetically\n 7 Sort by city\n 8 Sort by state\n 9 Sort by zip code \n 10 Write Contacts into text file\n 11 Read Contacts from text file" +
                        "\n 12 Write into csv file\n 13 Read from csv file\n 14 Write into JSON file\n 15 Read from JSON file\n 16 for exit");
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
                            Console.WriteLine("Enter 1 for city 2 for state");
                            string area= Console.ReadLine();
                            if (area.Contains("1"))
                            {
                                cityDictionary = FindPersonByCityOrState(adressBookDictionary,cityDictionary);
                                DisplayPersonDictionary(cityDictionary);
                            }
                            else
                            {
                                stateDictionary = FindPersonByCityOrState(adressBookDictionary, stateDictionary);
                                DisplayPersonDictionary(stateDictionary);
                            }
                            //FindPersonByCityOrState(adressBookDictionary,cityDictionary);
                            break;
                        case 6:
                            Console.WriteLine("Enter the address book name for sorting");
                            string sortByFirstNameInAddressBook = Console.ReadLine();
                            adressBookDictionary[sortByFirstNameInAddressBook].SortByFirstName();
                            break;
                        case 7:
                            Console.WriteLine("Enter the address book name for sorting");
                            string sortByCityInAddressBook = Console.ReadLine();
                            adressBookDictionary[sortByCityInAddressBook].SortByCity();
                            break;
                        case 8:
                            Console.WriteLine("Enter the address book name for sorting");
                            string sortByStateInAddressBook = Console.ReadLine();
                            adressBookDictionary[sortByStateInAddressBook].SortByState();
                            break;
                        case 9:
                            Console.WriteLine("Enter the address book name for sorting");
                            string sortByZip= Console.ReadLine();
                            adressBookDictionary[sortByZip].SortByZip();
                            break;
                        case 10:
                            Console.WriteLine("Enter Adress Book Name To write Contacts = ");
                            string writeInTextAddressBook = Console.ReadLine();
                            adressBookDictionary[writeInTextAddressBook].WriteInTxtFile();
                            break;
                        case 11:
                            Console.WriteLine("Enter Adress Book Name To read Contacts");
                            string readFromTextAddressBook= Console.ReadLine();
                            adressBookDictionary[readFromTextAddressBook].ReadFromTxtFile();
                            break;

                        case 12:
                            Console.WriteLine("Enter Adress Book Name To write Contacts = ");
                            string writeInCSVAddressBook = Console.ReadLine();
                            adressBookDictionary[writeInCSVAddressBook].WriteInCSVFile();
                            break;
                        case 13:
                            Console.WriteLine("Enter Adress Book Name To read Contacts");
                            string readFromCSVAddressBook = Console.ReadLine();
                            adressBookDictionary[readFromCSVAddressBook].ReadFromCSVFile();
                            break;
                        case 14:
                            Console.WriteLine("Enter Adress Book Name To write Contacts = ");
                            string writeInJSONAddressBook = Console.ReadLine();
                            adressBookDictionary[writeInJSONAddressBook].WriteInJSONFile();
                            break;
                        case 15:
                            Console.WriteLine("Enter Adress Book Name To read Contacts");
                            string readFromJSONAddressBook = Console.ReadLine();
                            adressBookDictionary[readFromJSONAddressBook].ReadFromJSONFile();
                            break;
                        case 16:
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
            if ((firstName != "") || (lastName != "") || (address != "") || (city != "") || (state != "") || (zip != "") || (email != "") || (phoneNumber != ""))
            {
                adressBookBuilder.AddContact(firstName, lastName, address, city, state, zip, phoneNumber, email);
            }
            else
            {
                Console.WriteLine("Empty string not allowed \n for add contacts please give the input in string");
            }
        }

        /// <summary>
        /// Finding the person by the city name or state name
        /// </summary>
        /// <param name="adressBookBuilder"> dictonary of addresss books </param>
        public static Dictionary<string, List<string>> FindPersonByCityOrState(Dictionary<string,AdressBookBuilder> adressBookBuilder, Dictionary<string, List<string>> areaDictionary)
        {
            Console.WriteLine("Enter the city or state where you want to view that person : ");
            string findPlace = Console.ReadLine();
            foreach (var element in adressBookBuilder)
            {
                List<string> listOfPersonFoundInPlace = element.Value.FindPerson(findPlace);
                foreach (var person in listOfPersonFoundInPlace)
                {
                    if (!areaDictionary.ContainsKey(findPlace))
                    {
                        List<string> personList = new List<string>();
                        personList.Add(person);
                        areaDictionary.Add(findPlace, personList);
                    }
                    else
                    {
                        areaDictionary[findPlace].Add(person);
                    }
                }
            }
            return areaDictionary;
        }

        public static void DisplayPersonDictionary(Dictionary<string,List<string>> areaDictionary)
        {
            int count = 0;
            foreach(var element in areaDictionary)
            {
                foreach (string person in element.Value)
                {
                    count++;
                    Console.WriteLine("Paeron name : "+person+" Area :"+element.Key);
                }
            }
            Console.WriteLine("Count : "+count);
        }
    }
}
