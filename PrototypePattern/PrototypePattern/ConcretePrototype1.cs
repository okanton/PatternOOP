using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class ConcretePrototype1 : AbstractPrototype
    {
        public ConcretePrototype1(int id) : base(id)
        { }

        public override AbstractPrototype Clone()
        {
            return new ConcretePrototype1(Id);
        }
    }
}
