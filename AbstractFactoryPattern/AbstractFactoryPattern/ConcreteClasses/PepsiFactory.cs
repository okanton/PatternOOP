using AbstractFactoryPattern.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.ConcreteClasses
{
    public class PepsiFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new PepsiCover();
        }

        public override AbstractLabel CreateLabel()
        {
            return new PepsiLable();
        }

        public override AbstractWater CreateWater()
        {
            return new PepsiWater();
        }
    }
}
