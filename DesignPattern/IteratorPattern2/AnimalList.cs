using System.Collections.Generic;
namespace DesignPattern.IteratorPattern2
{
    public class AnimalList: IAgregate
    {
        protected List<IAnimal> animals;
        private int last = 0;

        public AnimalList()
        {
            animals = new List<IAnimal>();
        }

        public void AddAnimal(IAnimal animal)
        {
            animals.Add(animal);
            last++;
        }

        public IAnimal GetAnimal(int index)
        {
            return animals[index];
        }

        public int GetAnimalCount()
        {
            return last;
        }

        public ITerator Iterator()
        {
            return new AnimalListIterator(this);
        } 
    }
}
