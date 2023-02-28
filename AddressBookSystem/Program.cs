namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");
            Contact contact = new Contact();
            AddressBookMain addressBookMain = new AddressBookMain();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your choice \n1.Add Contacts \n2.View Contacts \n3.Edit Contact \n4.Exit");
                Console.WriteLine("\nEnter option to execute");
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
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}