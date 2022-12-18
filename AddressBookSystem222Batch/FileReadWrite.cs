using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem222Batch
{
    public class FileReadWrite
    {
        /// <summary>
        /// path of the text file
        /// </summary>
        public static string textFilePath = @"C:\Users\HP\Desktop\RFP222\AddressBookSystem222Batch\AddressBookSystem222Batch\Contacts.txt";
        
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
        }
    }
}
