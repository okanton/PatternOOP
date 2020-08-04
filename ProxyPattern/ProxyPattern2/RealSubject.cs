using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern2
{
    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("RealSubject"); ;
        }
    }
}
