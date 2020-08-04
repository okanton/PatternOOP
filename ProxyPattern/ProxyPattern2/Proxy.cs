using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProxyPattern2
{
    public class Proxy : Subject
    {
        RealSubject realSubject;

        public override void Request()
        {
            if (realSubject == null) 
                realSubject = new RealSubject();
            
            realSubject.Request();
        }
    }
}
