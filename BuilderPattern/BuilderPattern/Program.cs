using System;

namespace BuilderPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            AbstractBuilder builder = new ConcreteBuilder();
            Foreman foreman = new Foreman(builder);
            foreman.Construct();

            builder.GetResult();
            
            Console.ReadKey();
        }
    }
}
