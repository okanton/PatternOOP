using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern_Class
{
    class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            base.SpecificRequest();
        }
    }
}
