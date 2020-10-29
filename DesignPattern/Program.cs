using DesignPattern.AdapterPattern1;
namespace DesignPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IVeteran veteran = new ExperiencedNewcomer();
            veteran.Create();
        }
    }
}
