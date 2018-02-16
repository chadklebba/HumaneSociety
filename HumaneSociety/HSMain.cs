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
            while (true)
            {
                MainMenu();
            }
            
        }
        public void MainMenu()
        {
            Console.Clear();
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
            Console.WriteLine("5. Look up room assignments");
            Console.WriteLine("6. Adopt an Animal");
            Console.WriteLine("7. List of available animals");
            Console.WriteLine("8. List of food per week per animal");
            Console.WriteLine("9. List of adopted animals");
            Console.WriteLine("10. Give an animal their shots");
            Console.WriteLine("0. To Exit");
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
                case 10:
                    {
                        GiveAnimalShots();
                        break;
                    }
                case 0:
                    {
                        Environment.Exit(0);
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
                        command.AddAnimaltoDB(dog);
                        break;
                    }
                case 2:
                    {
                        Cat cat = new Cat();
                        command.AddAnimaltoDB(cat);
                        break;
                    }
                case 3:
                    {
                        Bird bird = new Bird();
                        command.AddAnimaltoDB(bird);
                        break;
                    }
                case 4:
                    {
                        Rabbit rabbit = new Rabbit();
                        command.AddAnimaltoDB(rabbit);
                        break;
                    }
                case 5:
                    {
                        Ferret ferret = new Ferret();
                        command.AddAnimaltoDB(ferret);
                        break;
                    }
                case 6:
                    {
                        Lizard lizard = new Lizard();
                        command.AddAnimaltoDB(lizard);
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
            var searchedAnimals =command.SearchAnimalsinDB();
            DisplaySearchedAnimals(searchedAnimals);
        }
        public void AddAdopter()
        {
            Adopter adopter = new Adopter();
            adopter.Create();
            command.AddAdoptertoDB(adopter);
        }
        public void LookupAdopter()
        {
            var searchedAdopters = command.LookupAdopter();
            DisplaySearchedAdopters(searchedAdopters);
        }
        public void LookupRoom()
        {
            var roomList = command.AnimalList();
            DisplayRoomList(roomList);
        }
        public void MarkAsAdopted()
        {
            var searchedAnimals = command.SearchAnimalsinDB();
            DisplaySearchedAnimals(searchedAnimals);
            int adoptedAnimalID = AdoptAnAnimal(searchedAnimals);
            command.MarkAsAdopted(adoptedAnimalID);
        }
        public void ListAdoptedAnimals()
        {
            var adoptedAnimals = command.ListAdoptedAnimals();
            DisplaySearchedAnimals(adoptedAnimals);

        }
        public void ListAvailableAnimals()
        {
            var availableAnimals = command.ListAvailableAnimals();
            DisplaySearchedAnimals(availableAnimals);
        }
        public void ListFood()
        {
            var availableAnimals = command.ListAvailableAnimals();
            DisplayFoodForAnimals(availableAnimals);
        }
        public void DisplaySearchedAnimals(IEnumerable<Animal> List)
        {
            Console.Clear();
            foreach (var animal in List)
            {
                Console.WriteLine(animal.name + "  " + animal.type + "   $" + animal.cost + "   Room #" + animal.roomNumber);
            }
            Console.ReadLine();
        }

        public void DisplayAnimalsWithNoShots(IEnumerable<Animal> List)
        {
            Console.Clear();
            foreach (var animal in List)
            {
                Console.WriteLine("ID# " + animal.id + "  " + animal.name + "  " + animal.type + "  Room #" + animal.roomNumber);
            }
        }
        public void DisplayFoodForAnimals(IEnumerable<Animal> List)
        {
            Console.Clear();
            foreach (var animal in List)
            {
                Console.WriteLine(animal.name + "  " + animal.type + "  " + animal.foodNeeded + "  RM# " + animal.roomNumber);
            }
            Console.ReadLine();
        }

        public void DisplaySearchedAdopters(IEnumerable<Adopter> List)
        {
            Console.Clear();
            foreach (var adopter in List)
            {
                Console.WriteLine(adopter.firstName + " " + adopter.lastName);
                Console.WriteLine("Adopter ID: " + adopter.adpoterID);
                Console.WriteLine("Address: " + adopter.address);
                Console.WriteLine("Phone Number: " + adopter.phone);
                Console.WriteLine("Email: " + adopter.email);
                Console.WriteLine("Housing Info: " + adopter.housing);
                Console.WriteLine("Other Pets: " + adopter.otherPets);
                Console.WriteLine("Kids: " + adopter.kids);
                Console.WriteLine("\n" + "Please press enter to continue");
                Console.ReadLine();

            }
        }

        public void DisplayRoomList(IEnumerable<Animal> List)
        {
            Console.Clear();
            foreach (var animal in List)
            {
                if (animal.roomNumber != null)
                {
                    Console.Write(("Rm# " + animal.roomNumber).PadRight(8));
                    Console.WriteLine(animal.name);
                }
                
            }
            Console.WriteLine("Please press enter to continue");
            Console.ReadLine();
        }

        public int AdoptAnAnimal(IEnumerable<Animal> List)
        {
            Console.WriteLine("\n" + "Which animal would you like to adopt? (Please type their name)");
            string animalname = Console.ReadLine();
            var tempList = List.Where(m => m.name == animalname);
            foreach (var animal in tempList)
            {
                Console.WriteLine("The cost for " + animal.name  + " is $" + animal.cost);
                Console.WriteLine("Once the customer has paid for " + animal.name + " , please hit enter");
                Console.ReadLine();
                animal.adoptedStatus = true;
                animal.roomNumber = null;
                return animal.id;
            }
            return 0;

         }

        public void 
            GiveAnimalShots()
        {
            var searchedAnimals = command.ListShotsNeeded();
            DisplayAnimalsWithNoShots(searchedAnimals);
            Console.WriteLine("Please type in the ID# of the animal you want to give shots to");
            int id = Int32.Parse(Console.ReadLine());
            command.GiveShots(id);
        }


     }
            


 }
    

