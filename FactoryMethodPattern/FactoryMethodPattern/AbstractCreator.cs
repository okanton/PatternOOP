using System;
using System.Collections.Generic;
using System.Text; 

namespace FactoryMethodPattern
{
    public abstract class AbstractCreator
    {
        public abstract AbstractProduct FactoryMethod();
    }
}
