using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class ConcreteCreatorB : AbstractCreator
    {
        public override AbstractProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
