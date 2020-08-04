using AbstractFactoryPattern.ConcreteClasses;
using System;


//Назначение Абстрактной фабрики - порождение семейств взаимодействующих продуктов(т.е. бутылки, воды, пробки и т.д.)

namespace AbstractFactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new SchweppesFactory());
            client.CreateProduct();
            
            Console.ReadKey();
        }
    }
}
