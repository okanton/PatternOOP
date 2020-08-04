using System;

namespace AdapterPattern_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new Adapter();
            target.Request();
            Console.Read();
        }
    }
}
