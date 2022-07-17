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
            Console.WriteLine("Welcome to AddressBook problem");

           
            Records records = new Records();
            /*

            //UC7_CheckDuplicate
            while (true)
            {
                Console.WriteLine("\nEnter 1 to Add person in AddressBook");
                Console.WriteLine("Enter 2 to Display");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        records.AddRecord();
                        break;
                    case 2:
                        records.ToPrint();
                        break;
                    default:
                        Console.WriteLine("Pleasee select valid input");
                        break;

                }

            }
            */

            //UC8 -Search Person in city or State

            while (true)
            {
                Console.WriteLine("\nEnter 1 to Add person in AddressBook");
                Console.WriteLine("Enter 2 to Display");
                Console.WriteLine("Enter 3 to search the person by city");
                Console.WriteLine("Enter 4 to search the person by State");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        records.AddRecord();
                        break;
                    case 2:
                        records.ToPrint();
                        break;
                    case 3:
                        records.CheckByCity();
                        break;
                    case 4:
                        records.CheckByState();
                        break;
                    default:
                        Console.WriteLine("Pleasee select valid input");
                        break;

                }

            }
        }
    }
}
