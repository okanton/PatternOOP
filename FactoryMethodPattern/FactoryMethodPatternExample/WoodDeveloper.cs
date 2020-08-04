using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPatternExample
{
    public class WoodDeveloper : AbstractDeveloper
    {
        public WoodDeveloper(string name)
            : base(name)
        {

        }
        
        public override AbstractHouse Create()
        {
            return new WoodHouse();
        }
    }
}
