using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class ConcreteCreatorA : AbstractCreator
    {
        public override AbstractProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
