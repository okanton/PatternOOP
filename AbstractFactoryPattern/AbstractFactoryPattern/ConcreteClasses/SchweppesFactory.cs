using AbstractFactoryPattern.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.ConcreteClasses
{
    public class SchweppesFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new SchweppesBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new SchweppesCover();
        }

        public override AbstractLabel CreateLabel()
        {
            return new SchweppesLable();
        }

        public override AbstractWater CreateWater()
        {
            return new SchweppesWater();
        }
    }
}
