using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program\n");
            AddressBook addressBook = new AddressBook();

            addressBook.AddContact("Abhinav", "Kumar", "A-34 ", "New Delhi", "Delhi", 110023, 9876543210, "abc123@gmail.com");
            addressBook.ViewContact();

        }
    }
}