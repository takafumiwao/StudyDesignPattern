
namespace DesignPattern.IteratorPattern2
{
    public class AnimalListIterator: ITerator
    {
        private AnimalList animals;
        private int index = 0;
        public AnimalListIterator(AnimalList animals)
        {
            this.animals = animals;
        }

        public bool HasNext()
        {
           if (animals.GetAnimalCount() > index)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public IAnimal Next()
        {
            IAnimal a = animals.GetAnimal(index);
            index++;
            return a;
        }
    }
}
