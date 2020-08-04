using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern_Class
{
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("SpecificRequest");
        }
    }
}
