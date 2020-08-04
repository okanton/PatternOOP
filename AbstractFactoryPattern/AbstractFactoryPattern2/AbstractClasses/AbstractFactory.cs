using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern2.AbstractClasses
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        
        public abstract AbstractProductB CreateProductB();
    }
}
