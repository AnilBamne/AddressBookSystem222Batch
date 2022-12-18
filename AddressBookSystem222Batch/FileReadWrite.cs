using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace AddressBookSystem222Batch
{
    public class FileReadWrite
    {
        /// <summary>
        /// path of the text file,csvfile and json file
        /// </summary>
        public static string textFilePath = @"C:\Users\HP\Desktop\RFP222\AddressBookSystem222Batch\AddressBookSystem222Batch\Contacts.txt";
        public static string csvFilePath = @"C:\Users\HP\Desktop\RFP222\AddressBookSystem222Batch\AddressBookSystem222Batch\Contacts.csv";
        public static string jsonFilePath = @"C:\Users\HP\Desktop\RFP222\AddressBookSystem222Batch\AddressBookSystem222Batch\Contact.json";
        
        /// <summary>
        /// writing the contacts to a text file using StreamWriter 
        /// </summary>
        /// <param name="contactList"></param>
        public static void WriteIntoTextFile(List<Contact> contactList)
        {
            if (File.Exists(textFilePath))
            {
                using (StreamWriter sw = File.AppendText(textFilePath))
                {
                    foreach(Contact contact in contactList)
                    {
                        sw.WriteLine(contact);
                    }
                    sw.Close();
                }
                Console.WriteLine("Successfully written into text file");
            }
            else
            {
                Console.WriteLine("No File Beacuse Of Wrong Path Or File Name");
            }
        }

        /// <summary>
        /// Reading contactsfrom text file using StreamWriter
        /// </summary>
        public static void ReadFromTextFile()
        {
            if (File.Exists(textFilePath))
            {
                
                using(StreamReader sr = File.OpenText(textFilePath))
                {
                    string text = "";
                    while ((text = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(text);
                    }
                    sr.Close();
                }
            }
            else
            {
                Console.WriteLine("No File Beacuse Of Wrong Path Or File Name");
            }
        }

        /// <summary>
        ///writing the contacts to a csv file using StreamWriter
        /// </summary>
        /// <param name="contactList"></param>
        public static void WriteInCSVFile(List<Contact> contactList)
        {
            if (File.Exists(csvFilePath))
            {
                using(StreamWriter sw = File.AppendText(csvFilePath))
                {
                    foreach(Contact contact in contactList)
                    {
                        sw.WriteLine(contact.firstName + "," + contact.lastName + "," +contact.address+","+contact.city+","+contact.state+","+contact.zip+","+contact.phoneNumber+","+contact.email);
                    }
                    sw.Close();
                }
                Console.WriteLine("Successfully written in csv file");
            }
            else
            {
                Console.WriteLine("No File Beacuse Of Wrong Path Or File Name");
            }
        }

        /// <summary>
        /// Reading contacts data from csv file.
        /// </summary>
        public static void ReadFromCSVFile()
        {
            if (File.Exists(csvFilePath))
            {
                string[] data = File.ReadAllLines(csvFilePath);
                foreach(string line in data)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("No File Beacuse Of Wrong Path Or File Name");
            }
        }

        /// <summary>
        ///writing the contacts to a json file using StreamWriter
        /// </summary>
        /// <param name="contactList"></param>
        public static void WriteInJSONFile(List<Contact> contactList)
        {
            if (File.Exists(jsonFilePath))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                using(StreamWriter sw=new StreamWriter(jsonFilePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    jsonSerializer.Serialize(writer, contactList);
                }
                    Console.WriteLine("Successfully written into a JSON file");
            }
            else
            {
                Console.WriteLine("No File Beacuse Of Wrong Path Or File Name");
            }
        }

        /// <summary>
        /// Reading contacts data from json file.
        /// </summary>
        public static void ReadFromJSONFile()
        {
            if (File.Exists(jsonFilePath))
            {
                List<Contact> contactList=JsonConvert.DeserializeObject<List<Contact>>(File.ReadAllText(jsonFilePath));
                foreach(Contact contact in contactList)
                {
                    Console.Write("\n" + contact.firstName);
                    Console.Write("\n" + contact.lastName);
                    Console.Write("\n" + contact.address);
                    Console.Write("\n" + contact.city);
                    Console.Write("\n" + contact.state);
                    Console.Write("\n" + contact.zip);
                    Console.Write("\n" + contact.phoneNumber);
                    Console.Write("\n" + contact.email);
                }
            }
            else
            {
                Console.WriteLine("No File Beacuse Of Wrong Path Or File Name");
            }
        }
    }
}
