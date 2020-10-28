using System.Collections.Generic;
using System;
namespace DesignPattern.IteratorPattern2
{
    public class Keeper
    {
        private AnimalList animalList;

        public void CreateAnimalList(List<IAnimal> animals)
        {
            this.animalList = new AnimalList();

            foreach (IAnimal a in animals)
            {
                animalList.AddAnimal(a);
            }
        }

        public void CallAnimals()
        {
            AnimalListIterator itr = new AnimalListIterator(animalList);

            while (itr.HasNext())
            {
                IAnimal animal = itr.Next();

                string seek = "name:" + animal.GetName() + ","
                            + "weight:" + animal.GetWeight().ToString() + ","
                            + "cry:" + animal.Cry() + ","
                            + "favorite:" + animal.FavoriteFood();

                Console.WriteLine(seek);
                
            }

        }
    }
}
