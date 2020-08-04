using AbstractFactoryPattern2.ConcreteClasses;
using System;

namespace AbstractFactoryPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client product = new Client(new Factory2());
            product.CreateProduct();
            Console.ReadKey();
        }
    }
}
