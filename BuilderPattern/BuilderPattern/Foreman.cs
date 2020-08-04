using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Foreman
    {
        AbstractBuilder abstractBuilder;

        public Foreman(AbstractBuilder abstractBuilder)
        {
            this.abstractBuilder = abstractBuilder;
        }

        public void Construct()
        {
            //Требуется дать правильный порядо построения объекта. Сначала фундамент, потом этаж, потом крыша
            abstractBuilder.BuildBasement();
            abstractBuilder.BuildStorey();
            abstractBuilder.BuildRoof();
        }
    }
}
