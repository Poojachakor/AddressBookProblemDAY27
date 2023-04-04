using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDay27
{
    class JsonOperation
    {
        string filePath = @"C:\Users\hp\source\repos\AddressBookDay27\AddressBookDay27\Utility\AddressBookRecord.json";
        public void WriteToFile(Dictionary<string, AddressBookManagement> addressBookDictionary)
        {
            string json = "";
            foreach (AddressBookManagement obj in addressBookDictionary.Values)
            {
                foreach (Contact contact in obj.addressBook.Values)
                {
                    json = JsonConvert.SerializeObject(contact);
                    File.WriteAllText(filePath, json);
                }
            }
            Console.WriteLine("\nSuccessfully added to JSON file.");
        }
        public void ReadFromFile()
        {
            Console.WriteLine("Below are Contents of JSON File");
            var json = File.ReadAllText(filePath);
            Contact contact = JsonConvert.DeserializeObject<Contact>(json);
            Console.WriteLine(contact.ToString());
        }
    }
}

