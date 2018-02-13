using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public abstract class Animal
    {
        string type;
        int roomNumber;
        bool adoptedStatus = false;
        int cost;
        bool hasShots;
        string foodNeeded;

        public void Create()
        {
            Console.Clear();
            Console.WriteLine("What type of " + GetType().Name + " are you adding?");
            type = Console.ReadLine();
            Console.WriteLine("What room number is the " + GetType().Name + " in?");
            roomNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the cost of this " + GetType().Name + " in dollars?");
            cost = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Does the " + GetType().Name + " have all of its shots? (y/n)");
            string answer = Console.ReadLine();
            hasShots = answer == "y" ? true : false;
            Console.WriteLine("Please enter the type and amount of food per week for the " + GetType().Name + ":");
            foodNeeded = Console.ReadLine();
        }
    }
}
