using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class ConcreteDecoratorA : Decorator
    {
        string addedState = "Some State";

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine(addedState);
        }
    }
}
