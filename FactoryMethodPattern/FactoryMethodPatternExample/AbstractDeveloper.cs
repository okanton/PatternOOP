using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPatternExample
{
    public abstract class AbstractDeveloper
    {
        public string Name { get; set; }

        protected AbstractDeveloper(string name)
        {
            Name = name;
        }

        public abstract AbstractHouse Create();
    }
}
