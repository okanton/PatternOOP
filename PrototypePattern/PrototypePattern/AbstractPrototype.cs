using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public abstract class AbstractPrototype
    {
        public int Id { get; private set; }
        
        public AbstractPrototype(int id)
        {
            this.Id = id;
        }
        public abstract AbstractPrototype Clone();
    }
}
