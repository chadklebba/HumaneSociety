using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    partial class Adopter
    {
        
        public void Create()
        {
            Console.Clear();
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            Console.WriteLine("What is your address? (Street, City, Zip");
            address = Console.ReadLine();
            Console.WriteLine("What is your phone number?");
            phone = Console.ReadLine();
            Console.WriteLine("What is your email address?");
            email = Console.ReadLine();
            Console.WriteLine("Do you have other pets? (y/n)");
            string answer = Console.ReadLine();
            otherPets = answer == "y" ? true : false;
            Console.WriteLine("Do you have kids? (y/n)");
            string answer2 = Console.ReadLine();
            kids = answer2 == "y" ? true : false;
            Console.WriteLine("Please enter information about your housing:");
            housing = Console.ReadLine();
        }
    }
}
