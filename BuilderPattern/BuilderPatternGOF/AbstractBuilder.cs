using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternGOF
{
    public abstract class AbstractBuilder
    {
        public abstract void BuildPartA();

        public abstract void BuildPartB();

        public abstract Product GetResult();
    }
}
