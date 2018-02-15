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
    }
}
