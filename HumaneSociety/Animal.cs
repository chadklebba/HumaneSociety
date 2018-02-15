using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public partial class Animal
    {
        public Animal(Animal animal)
        {
            this.type = animal.type;
            this.roomNumber = animal.roomNumber;
            this.adoptedStatus = animal.adoptedStatus;
            this.cost = animal.cost;
            this.hasShots = animal.hasShots;
            this.foodNeeded = animal.foodNeeded;
            this.id = animal.id;
            this.name = animal.name;
                      
        }
        

        public void Create()
        {
            Console.Clear();
            Console.WriteLine("What is your " + GetType().Name + "'s name?");
            name = Console.ReadLine();
            Console.WriteLine("What type of " + GetType().Name + " are you adding?");
            type = Console.ReadLine();
            Console.WriteLine("What room number is the " + GetType().Name + " in?");
            roomNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the cost of this " + GetType().Name + " in dollars?");
            cost = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Does the " + GetType().Name + " have all of its shots? (y/n)");
            string answer = Console.ReadLine();
            hasShots = answer == "y" ? true : false;
            animalClass = GetType().Name;
            Console.WriteLine("Please enter the type and amount of food per week for the " + GetType().Name + ":");
            foodNeeded = Console.ReadLine();
        }
    }
}
