using System;
namespace DesignPattern.IteratorPattern2
{
    public class Dog: IAnimal
    {
        private readonly string name;
        private readonly int weight;

        public Dog(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetWeight()
        {
            return this.weight;
        }

        public string Cry()
        {
            return "BOW";
        }

        public string FavoriteFood()
        {
            return "Bone";
        }
    }
}
