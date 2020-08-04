using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPatternExample
{
    public class PanelDeveloper : AbstractDeveloper
    {
        public PanelDeveloper(string name) : base(name)
        {}

        public override AbstractHouse Create()
        {
            return new PanelHouse();
        }
    }
}
