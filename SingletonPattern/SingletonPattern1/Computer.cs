using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern1
{
    class Computer
    {
        public Os Os { get; set; }

        public void Launch(string osName)
        {
            Os = Os.GetInstance(osName);
        }
    }
}
