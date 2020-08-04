using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public abstract class AbstractBuilder
    {
        public abstract void BuildBasement();
        
        public abstract void BuildStorey();
        
        public abstract void BuildRoof();
        
        public abstract House GetResult();
    }
}
