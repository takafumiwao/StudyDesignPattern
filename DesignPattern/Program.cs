using DesignPattern.IteratorPattern2;
using System.Collections.Generic;
namespace DesignPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IAnimal dog = new Dog("dog", 15);
            IAnimal cat = new Cat("cat", 7);

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(dog);
            animals.Add(cat);

            Keeper keeper = new Keeper();
            keeper.CreateAnimalList(animals);
            keeper.CallAnimals();
            
        }
    }
}
