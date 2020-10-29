using System;
namespace DesignPattern.AdapterPattern1
{
    public class ExperiencedNewcomer: IVeteran
    {
        public ExperiencedNewcomer()
        {
        }

        public void Create()
        {
            Console.WriteLine("Make amazing things");
        }
    }
}
