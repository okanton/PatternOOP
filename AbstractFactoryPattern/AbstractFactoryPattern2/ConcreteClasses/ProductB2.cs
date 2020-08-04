using AbstractFactoryPattern2.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern2.ConcreteClasses
{
    public class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA productA)
        {
            Console.WriteLine(this + " interact with " + productA);
        }
    }
}
