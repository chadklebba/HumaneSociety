using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class HSMain
    {
        public List<Animal> animalList;
        public List<Adopter> adopterList;
        public SQLCommand command;
        public HSMain()
        {
            animalList = new List<Animal>();
            adopterList = new List<Adopter>();
            command = new SQLCommand();
        }
        public void RunProgram()
        {
            MainMenu();
        }
        public void MainMenu()
        {
            string ls = "Humane Society";
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (ls.Length / 2)) + "}", ls) + "\n");
            Console.ResetColor();
            Console.WriteLine("Main Menu:");
            Console.WriteLine("----------");
            Console.WriteLine("1. Add an animal");
            Console.WriteLine("2. Lookup an animal");
            Console.WriteLine("3. Add an adopter");
            Console.WriteLine("4. Look up an adopter");
            Console.WriteLine("5. Look up room assignment");
            Console.WriteLine("6. Mark an animal as adopted");
            Console.WriteLine("7. List of available animals");
            Console.WriteLine("8. List of food per week per animal");
            Console.WriteLine("9. List if adopted animals");
            int answer = Int32.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    {
                        AddAnimal();
                        break;
                    }
                case 2:
                    {
                        LookupAnimal();
                        break;
                    }
                case 3:
                    {
                        AddAdopter();
                        break;
                    }
                case 4:
                    {
                        LookupAdopter();
                        break;
                    }
                case 5:
                    {
                        LookupRoom();
                        break;
                    }
                case 6:
                    {
                        MarkAsAdopted();
                        break;
                    }
                case 7:
                    {
                        ListAvailableAnimals();
                        break;
                    }
                case 8:
                    {
                        ListFood();
                        break;
                    }
                case 9:
                    {
                        ListAdoptedAnimals();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You didn't select a number from the menu, please press enter to try again");
                        Console.ReadLine();
                        Console.Clear();
                        MainMenu();
                        break;
                    }
            }
        }
        public void AddAnimal()
        {
            Console.Clear();
            string ls = "Add an animal";
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (ls.Length / 2)) + "}", ls) + "\n");
            Console.ResetColor();
            Console.WriteLine("What type of animal would you like to add?");
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Cat");
            Console.WriteLine("3. Bird");
            Console.WriteLine("4. Rabbit");
            Console.WriteLine("5. Ferret");
            Console.WriteLine("6. Lizard");
            int number = Int32.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    {
                        Dog dog = new Dog();
                        break;
                    }
                case 2:
                    {
                        Cat cat = new Cat();
                        break;
                    }
                case 3:
                    {
                        Bird bird = new Bird();
                        break;
                    }
                case 4:
                    {
                        Rabbit rabbit = new Rabbit();
                        break;
                    }
                case 5:
                    {
                        Ferret ferret = new Ferret();
                        break;
                    }
                case 6:
                    {
                        Lizard lizard = new Lizard();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please select a number from the list, please press enter and try again");
                        Console.ReadLine();
                        AddAnimal();
                        break;
                    }

            }
        }
        public void LookupAnimal()
        {

        }
        public void AddAdopter()
        {

        }
        public void LookupAdopter()
        {

        }
        public void LookupRoom()
        {

        }
        public void MarkAsAdopted()
        {

        }
        public void ListAdoptedAnimals()
        {

        }
        public void ListAvailableAnimals()
        {

        }
        public void ListFood()
        {

        }
    }
}
