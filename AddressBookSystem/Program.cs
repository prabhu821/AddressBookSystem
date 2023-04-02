using System;

namespace AddressBookSystem;

public class Program
{
    static void Main(string[] args)
    {
        string personsContact = @"C:\Users\91789\OneDrive\Desktop\bridgelabz\AddressBookSystem\AddressBookSystem\PersonsContact.txt";
        PersonsContactUsingFileIO fileIO = new PersonsContactUsingFileIO();
        Console.WriteLine("Welcome to Address Book System");
        Contact contact = new Contact();
        AddressBookMain addressBookMain = new AddressBookMain();
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\nEnter your choice \n1.Add Contacts \n2.View Contacts \n3.Edit Contact \n4.Delete Contact " +
                "\n5.Add Multiple Person \n6.Add Multiple AddressBook using Dictionary \n7.Display List of Dictionary \n8.Check for Duplicate Contacts " +
                "\n9.Search Person by City or State \n10.View Person by City or State \n11.Count contact \n12.Sort Contact by Name " +
                "\n13.Sort Contact By City _State_ZipCode \n14.File Exit or Not \n15.Read Person File \n16.Write Person File \n17.Person Contact as CSV file " +
                "\n18.Exit");
            Console.WriteLine("Enter option to execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    addressBookMain.AddContact();
                    Console.WriteLine("\n");
                    break;
                case 2:
                    addressBookMain.ViewDetail();
                    Console.WriteLine("\n");
                    break;
                case 3:
                    addressBookMain.EditContact();
                    break;
                case 4:
                    addressBookMain.DeleteContact();
                    break;
                case 5:
                    addressBookMain.AddMultiplePerson();
                    break;
                case 6:
                    addressBookMain.CreateDictionary();
                    break;
                case 7:
                    addressBookMain.DisplayDicttionaryList();
                    break;
                case 8:
                    addressBookMain.DuplicateContact();
                    break;
                case 9:
                    addressBookMain.SearchPersonByCityOrState();
                    break;
                case 10:
                    addressBookMain.ViewPersonByCityOrState();
                    break;
                case 11:
                    addressBookMain.CountPerson();
                    break;
                case 12:
                    addressBookMain.SortContactByName();
                    break;
                case 13:
                    addressBookMain.SortContactByCity_State_ZipCode();
                    break;
                case 14:
                    fileIO.CheckPersonsContactsFileExists(personsContact);
                    break;
                case 15:
                    fileIO.ReaderPersonsContactsFile(personsContact);
                    break;
                case 16:
                    fileIO.WriterPersonsContactsFile(personsContact);
                    break;
                case 17:
                    PersonsContactsAsCSVFile.ReadCSVWriteCSV();
                    break;
                default:
                    flag = false;
                    break;
            }
        }
    }
}