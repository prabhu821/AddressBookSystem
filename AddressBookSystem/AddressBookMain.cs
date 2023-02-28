using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem;

public class AddressBookMain
{
    public static List<Contact> AddressBook = new List<Contact>();

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
}
