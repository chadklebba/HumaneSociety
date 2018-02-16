using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class SQLCommand
    {
        DBDataContext context = new DBDataContext();
        public SQLCommand()
        {
           
        }
        public void AddAnimaltoDB(Animal animal)
        {
            Animal insert = new Animal(animal);
            context.Animals.InsertOnSubmit(insert);
            context.SubmitChanges();
        }

        public IEnumerable<Animal> SearchAnimalsinDB()
        {
            List<Animal> animalList = (from data in context.Animals select data).ToList();
            Console.WriteLine("What kind of animal are you searching for? (Dog, Cat, Bird, Rabbit, Ferret, Lizard)");
            string getkind = Console.ReadLine();
            var tempList = animalList.Where(m => m.animalClass == getkind);
            Console.WriteLine("What is the max price that you want to pay? (In dollars)");
            int getcost = Int32.Parse(Console.ReadLine());
            tempList = tempList.Where(m => m.cost <= getcost);
            return tempList;
        }
        public void AddAdoptertoDB(Adopter adopter)
        {
            context.Adopters.InsertOnSubmit(adopter);
            context.SubmitChanges();
        }

        public IEnumerable<Adopter> LookupAdopter()
        {
            List<Adopter> adopterList = (from data in context.Adopters select data).ToList();
            Console.WriteLine("What is the last name of the adopter you want to look up?");
            string getLastName = Console.ReadLine();
            var tempList = adopterList.Where(m => m.lastName == getLastName);
            return tempList;
        }

        public IEnumerable<Animal> AnimalList()
        {
            List<Animal> roomList = (from data in context.Animals select data).ToList();
            return roomList;
        }

        public void MarkAsAdopted(int id)
        {
            Animal animal = new Animal();
            animal = (from data in context.Animals where data.id == id select data).FirstOrDefault();
            animal.adoptedStatus = true;
            context.SubmitChanges();
        }

        public void GiveShots(int id)
        {
            Animal animal = new Animal();
            animal = (from data in context.Animals where data.id == id select data).FirstOrDefault();
            animal.hasShots = true;
            context.SubmitChanges();
        }

        public IEnumerable<Animal> ListAvailableAnimals()
        {
            List<Animal> availableList = (from data in context.Animals where data.adoptedStatus == false select data).ToList();
            return availableList;
        }

        public IEnumerable<Animal> ListAdoptedAnimals()
        {
            List<Animal> adoptedList = (from data in context.Animals where data.adoptedStatus == true select data).ToList();
            return adoptedList;
        }

        public IEnumerable<Animal> ListShotsNeeded()
        {
            List<Animal> shotsNeededList = (from data in context.Animals where data.hasShots == false select data).ToList();
            return shotsNeededList;
        }
    }
}
