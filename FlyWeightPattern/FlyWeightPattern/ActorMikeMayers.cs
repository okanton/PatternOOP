using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPattern
{
    public class ActorMikeMayers : Flyweight
    {
        public override void Greeting(string speech)
        {
            Console.WriteLine(speech);
        }
    }
}
