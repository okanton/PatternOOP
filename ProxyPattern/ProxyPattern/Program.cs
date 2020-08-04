using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IHuman Bruce = new Operator();
            IHuman surrogate = new Surrogate(Bruce);

            surrogate.Reques();

            Console.Read();
        }
    }
}
