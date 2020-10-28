using System;
namespace DesignPattern.IteratorPattern1
{
    public interface ITerator
    {
        bool HasNext();
        Book Next();
    }
}
