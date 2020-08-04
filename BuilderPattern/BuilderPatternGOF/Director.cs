using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternGOF
{
    public class Director
    {
        private AbstractBuilder builder;

        public Director(AbstractBuilder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
