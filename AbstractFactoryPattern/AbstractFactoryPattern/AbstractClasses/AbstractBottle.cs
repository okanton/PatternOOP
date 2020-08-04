using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.AbstractClasses
{
    public abstract class AbstractBottle
    {
        //метод взаимоодействия абстрактной воды с абстрактной бутылкой
        public abstract void Interact(AbstractWater abstractWater);

        public abstract void Interact(AbstractCover abstractCover);

        public abstract void Interact(AbstractLabel abstractLabel);
    }
}
