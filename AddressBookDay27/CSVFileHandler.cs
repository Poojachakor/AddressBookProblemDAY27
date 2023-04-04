using CsvHelper;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDay27
{
    
    
        public class CSVFileHandler
        {
            private string filePath = @"C:\Users\hp\source\repos\AddressBookDay27\AddressBookDay27\Utility\AddressBookCsvFile.csv";
            public void WriteToFile(Dictionary<string, AddressBookManagement> addressBookDictionary)
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    using (CsvWriter csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {
                        foreach (AddressBookManagement obj in addressBookDictionary.Values)
                        {
                            List<Contact> contactRecord = obj.addressBook.Values.ToList();
                            csv.WriteRecords(contactRecord);
                        }
                        Console.WriteLine("\nSuccessfully added to CSV file.");
                        csv.Dispose();
                    }
                }
            }
            public void ReadFromFile()
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    using (CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        Console.WriteLine("Below are Contents of CSV File");
                        List<Contact> contactRecord = csv.GetRecords<Contact>().ToList();
                        foreach (Contact contact in contactRecord)
                        {
                            Console.WriteLine(contact.ToString());
                        }
                    }
                }
            }
        }
    
}
