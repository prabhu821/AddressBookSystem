using System;

namespace AddressBookSystem;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book System");
        Contact contact = new Contact();
        AddressBookMain addressBookMain = new AddressBookMain();
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\nEnter your choice \n1.Add Contacts \n2.View Contacts \n3.Edit Contact \n4.Delete Contact " +
                "\n5.Add Multiple Person \n6.Add Multiple AddressBook using Dictionary \n7.Display List of Dictionary \n8.Check for Duplicate Contacts " +
                "\n9.Search Person by City or State \n10.View Person by City or State \n11.Exit");
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
                default:
                    flag = false;
                    break;
            }
        }
    }
}