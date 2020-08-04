using AbstractFactoryPattern.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.ConcreteClasses
{
    public class CocaColaFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }

        public override AbstractCover CreateCover()
        {
           return new CocaColaCover();
        }

        public override AbstractLabel CreateLabel()
        {
            return new CocaColaLabel();
        }

        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }
    }
}
