using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class Operator : IHuman
    {
        public void Reques()
        {
            Console.WriteLine("Operator");
        }
    }
}
