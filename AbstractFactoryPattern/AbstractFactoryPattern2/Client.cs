using AbstractFactoryPattern2.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern2
{
    public class Client
    {
        private AbstractProductA productA;
        private AbstractProductB productB;

        public Client(AbstractFactory abstractFactory)
        {
            this.productA = abstractFactory.CreateProductA();
            this.productB = abstractFactory.CreateProductB();
        }

        public void CreateProduct()
        {
            this.productB.Interact(this.productA);   
        }
    }
}
