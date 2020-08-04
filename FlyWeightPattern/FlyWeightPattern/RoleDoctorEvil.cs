using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPattern
{
    public class RoleDoctorEvil : Flyweight
    {
        Flyweight flyweight;
        
        public RoleDoctorEvil(Flyweight flyweight)
        {
            this.flyweight = flyweight;
        }

        public override void Greeting(string speech)
        {
            this.flyweight.Greeting(speech);
        }
    }
}
