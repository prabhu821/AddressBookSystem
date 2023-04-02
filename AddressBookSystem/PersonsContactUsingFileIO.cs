using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem;

internal class PersonsContactUsingFileIO
{
    public void CheckPersonsContactsFileExists(string filePath)
    {
        if (File.Exists(filePath))
        {
            Console.WriteLine("File Exists");
        }
        else
        {
            Console.WriteLine("File not exists");
        }
    }
    public void ReaderPersonsContactsFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            using (StreamReader sr = File.OpenText(filePath))
            {
                String s = "";
                while ((s=sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        else
        {
            Console.WriteLine("File not exists");
        }
    }

    public void WriterPersonsContactsFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            using (StreamWriter sr = File.AppendText(filePath))
            {
                string word = "\r\nFName   :-   Vinesh\r\nLName   :-   Kumar\r\nAddress   :-   Bus Station Road" +
                    "\r\nCity   :-   Moradabad\nState   :-   Uttar Pradesh\r\nZip   :-   203130\r\nPhoneNumber   :-   741852963" +
                    "\r\nEmail   :-   vin243esh@gmail.com\r\n";
                sr.WriteLine(word);
                sr.Close();
                Console.WriteLine(File.ReadAllText(filePath));
            }
        }
        else
        {
            Console.WriteLine("File not exists");
        }
    }
}
