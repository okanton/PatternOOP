using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.AbstractClasses
{
    public abstract class AbstractFactory
    {
        public abstract AbstractWater CreateWater();

        public abstract AbstractBottle CreateBottle();

        public abstract AbstractCover CreateCover();

        public abstract AbstractLabel CreateLabel();
    }
}
