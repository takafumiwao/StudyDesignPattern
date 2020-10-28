using System;
namespace DesignPattern.IteratorPattern2
{
    public interface ITerator
    {
        bool HasNext();
        IAnimal Next();
    }
}
