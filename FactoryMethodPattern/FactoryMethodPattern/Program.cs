using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractCreator creator = new ConcreteCreatorA();
            AbstractProduct product = creator.FactoryMethod();

            Console.ReadKey();
        }
    }
}
