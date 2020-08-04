using System;

namespace PrototypePattern
{
    abstract class Test
    {
        public abstract Test Clone();    
    }


    class Program: Test
    {
        static void Main(string[] args)
        {
            
        }

        public override Test Clone()
        {
            return this.MemberwiseClone() as Test; ;
        }
    }
}
