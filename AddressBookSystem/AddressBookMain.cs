using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem;

public class AddressBookMain
{
    public static List<Contact> AddressBook = new List<Contact>();
    public static Dictionary<string, List<Contact>> DictionaryBook = new Dictionary<string, List<Contact>>();

    //UC2
    public void AddContact()
    {
        Contact contacts = new Contact();

        Console.Write("Enter the First Name : ");
        contacts.FName = Console.ReadLine();

        Console.Write("Enter the last Name  : ");
        contacts.LName = Console.ReadLine();

        Console.Write("Enter the address  : ");
        contacts.Address = Console.ReadLine();

        Console.Write("Enter the City  : ");
        contacts.City = Console.ReadLine();

        Console.WriteLine("Enter the state : ");
        contacts.State = Console.ReadLine();

        Console.Write("Enter Zip Code  : ");
        contacts.Zip = Console.ReadLine();

        Console.Write("Enter Your Phone Number: ");
        contacts.PhoneNumber = Console.ReadLine();

        Console.Write("Enter Your Email Address: ");
        contacts.Email = Console.ReadLine();

        AddressBook.Add(contacts);
    }

    public void ViewDetail()
    {
        if (AddressBook.Count > 0)
        {
            foreach (var item in AddressBook)
            {
                Console.WriteLine("First Name :   " + item.FName);
                Console.WriteLine("Last Name :    " + item.LName);
                Console.WriteLine("Address :      " + item.Address);
                Console.WriteLine("City    :      " + item.City);
                Console.WriteLine("State   :      " + item.State);
                Console.WriteLine("Zip     :      " + item.Zip);
                Console.WriteLine("Phone Number  : " + item.PhoneNumber);
                Console.WriteLine("Email  :       " + item.Email);
            }
        }
        else
        {
            Console.WriteLine("Address book is empty! ");
        }
    }

    //UC3
    public void EditContact()
    {
        if (AddressBook.Count > 0)
        {
            Console.Write("Enter Name of the contact you want to edit: ");
            string editDetails = Console.ReadLine();

            foreach (var item in AddressBook)
            {
                if (editDetails.ToLower() == item.FName.ToLower())
                {
                    Console.WriteLine("\nChoice what you want to edit \n1.First name \n2.Last name \n3.Address" +
                        "\n4.City \n5.State \n6.Zip Code \n7.Phone Number \n8.Email");

                    int editChoice = int.Parse(Console.ReadLine());

                    switch (editChoice)
                    {
                        case 1:
                            Console.Write("Enter new First Name: ");
                            item.FName = Console.ReadLine();
                            break;

                        case 2:
                            Console.Write("Enter new Last Name: ");
                            item.LName = Console.ReadLine();
                            break;

                        case 3:
                            Console.Write("Enter Your new Address: ");
                            item.Address = Console.ReadLine();
                            break;

                        case 4:
                            Console.Write("Enter Your new City Name: ");
                            item.City = Console.ReadLine();
                            break;

                        case 5:
                            Console.Write("Enter new State Name: ");
                            item.State = Console.ReadLine();
                            break;
                        case 6:
                            Console.Write("Enter new Zip Code: ");
                            item.Zip = Console.ReadLine();
                            break;
                        case 7:
                            Console.Write("Enter new Phone Number: ");
                            item.PhoneNumber = Console.ReadLine();
                            break;
                        case 8:
                            Console.Write("Enter new Email Address: ");
                            item.Email = Console.ReadLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("{0} does not exists in Address Book.", editDetails);
                }
            }
        }
    }

    //UC4
    public void DeleteContact()
    {
        if (AddressBook.Count > 0)
        {
            Console.Write("Enter name of contact you want to delete: ");
            string deleteName = Console.ReadLine();

            foreach (var item in AddressBook)
            {
                if (item.FName.ToLower() == deleteName.ToLower())
                {
                    AddressBook.Remove(item);
                    Console.WriteLine(deleteName + "'s contact is successfully deleted.");
                    return;
                }
            }
        }
        else
        {
            Console.WriteLine("Address Book is empty!");
        }
    }

    //UC5
    public void AddMultiplePerson()
    {
        Console.WriteLine("Please enter number of person to add in Contact");
        int numberPerson = Convert.ToInt32(Console.ReadLine());
        while (numberPerson > 0)
        {
            AddContact();
            numberPerson--;
        }
    }

    //UC6
    public void CreateDictionary()
    {
        Console.WriteLine("Enter Bookname of address book");
        string Bookname = Console.ReadLine();//key 
        Console.WriteLine("Please enter number of person add in Contact");
        int numberPerson = Convert.ToInt32(Console.ReadLine());
        while (numberPerson > 0)
        {
            AddContact();
            numberPerson--;
        }
        DictionaryBook.Add(Bookname, AddressBook.ToList());
    }
    public void DisplayDicttionaryList()
    {
        foreach (var pair in DictionaryBook.Keys)
        {
            Console.WriteLine("Address Book Name " + pair);
            foreach (Contact data in DictionaryBook[pair])
            {
                Console.WriteLine("First Name :   " + data.FName);
                Console.WriteLine("Last Name :    " + data.LName);
                Console.WriteLine("Address :      " + data.Address);
                Console.WriteLine("City    :      " + data.City);
                Console.WriteLine("State   :      " + data.State);
                Console.WriteLine("Zip     :      " + data.Zip);
                Console.WriteLine("Phone Number  : " + data.PhoneNumber);
                Console.WriteLine("Email  :       " + data.Email);
            }
        }
    }

    //UC7
    public void DuplicateContact()
    {
        if (AddressBook.Count > 0)
        {
            Console.WriteLine("Enter the name you want to check:");
            string personName = Console.ReadLine();
            bool check = AddressBook.Any(x => x.FName == personName);
            if (check)
            {
                Console.WriteLine("Contact present in address book");
            }
            else
            {
                Console.WriteLine("Contact is not present");
            }
        }
        else
        {
            Console.WriteLine("Address book is empty! ");
        }
    }
}
