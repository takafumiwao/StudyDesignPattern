using System;
namespace DesignPattern.AdapterPattern1
{
    public class ChairPerson: IChairperson
    { 
        public void OrganizeOffice()
        {
            Console.WriteLine("Excitement");
        }
    }
}
