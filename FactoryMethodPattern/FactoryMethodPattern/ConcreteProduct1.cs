using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class ConcreteProduct1: AbstractProduct
    {
        public ConcreteProduct1()
        {
            Console.WriteLine(this.GetHashCode());
        }
    }
}
