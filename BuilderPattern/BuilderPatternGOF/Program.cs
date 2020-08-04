using System;

namespace BuilderPatternGOF
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractBuilder builder = new ConcreteBuilder();
            Director director = new Director(builder);
            director.Construct();

            Product product = builder.GetResult();
            product.Show();

            Console.ReadKey();


        }
    }
}
