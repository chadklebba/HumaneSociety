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
        public HSMain()
        {
            animalList = new List<Animal>();
            adopterList = new List<Adopter>();
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
            Console.WriteLine("6. List of adopted animals");
            Console.WriteLine("7. List of available animals");
            Console.WriteLine("8. List of food per week per animal");
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
                        ListAdoptedAnimals();
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
