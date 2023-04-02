using CsvHelper;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem;

public class PersonsContactsAsCSVFile
{
    public static string importfilePath = @"C:\Users\91789\OneDrive\Desktop\bridgelabz\AddressBookSystem\AddressBookSystem\Import.csv";
    public static string exportfilePath = @"C:\Users\91789\OneDrive\Desktop\bridgelabz\AddressBookSystem\AddressBookSystem\Export.csv";
    public static void ReadCSVWriteCSV()
    {
        using (var reader = new StreamReader(importfilePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<Contact>().ToList();
            Console.WriteLine("Read Data from csvFile");
            foreach (Contact contact in records)
            {
                Console.Write("\n" + contact.FName);
                Console.Write("\n" + contact.LName);
                Console.Write("\n" + contact.Address);
                Console.Write("\n" + contact.City);
                Console.Write("\n" + contact.State);
                Console.Write("\n" + contact.Zip);
                Console.Write("\n" + contact.PhoneNumber);
                Console.Write("\n" + contact.Email);
                Console.Write("\n");
            }

            using (var writer = new StreamWriter(exportfilePath))
            using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvExport.WriteRecords(records);
            }
        }
    }
}

