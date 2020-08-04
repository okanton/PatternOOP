using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class Surrogate : IHuman
    {
        IHuman @operator;
        
        public Surrogate(IHuman @operator)
        {
            this.@operator = @operator;
        }

        public void Reques()
        {
            this.@operator.Reques();
        }
    }
}
