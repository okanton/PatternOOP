using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class ConcreteProduct2 : AbstractProduct
    {
        public ConcreteProduct2()
        {
            Console.WriteLine(this.GetHashCode());
        }
    }
}
