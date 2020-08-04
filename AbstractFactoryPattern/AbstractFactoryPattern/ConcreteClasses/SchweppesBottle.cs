using AbstractFactoryPattern.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.ConcreteClasses
{
    public class SchweppesBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine(this + " interact with " + water);
        }

        public override void Interact(AbstractCover cover)
        {
            Console.WriteLine(this + " interact with " + cover);
        }

        public override void Interact(AbstractLabel label)
        {
            Console.WriteLine(this + " interact with " + label);
        }
    }
}
