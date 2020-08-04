using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class House
    {
        ArrayList parts = new ArrayList();

        public void Add(object part)
        {
            parts.Add(part);
        }
    }
}
