using System;

namespace FactoryMethodPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDeveloper developer = new PanelDeveloper("Бабкины семечки");
            developer.Create();

            AbstractDeveloper developer1 = new WoodDeveloper("Деревянные дома");
            developer1.Create();

            Console.ReadKey();
        }
    }
}
