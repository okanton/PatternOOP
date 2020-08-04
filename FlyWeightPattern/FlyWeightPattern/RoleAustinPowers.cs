using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPattern
{
    public class RoleAustinPowers : Flyweight
    {
        Flyweight flyweight;

        public RoleAustinPowers(Flyweight flyweight)
        {
            this.flyweight = flyweight;
        }
        public override void Greeting(string speech)
        {
            this.flyweight.Greeting(speech);
        }
    }
}
