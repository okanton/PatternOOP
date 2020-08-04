using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    abstract class Decorator:Component
    {
        public Component Component { protected get; set; }

        public override void Operation()
        {
            if (Component != null)
                Component.Operation();
        }
    }
}
