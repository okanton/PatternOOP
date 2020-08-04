﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternGOF
{
    public class ConcreteBuilder : AbstractBuilder
    {
        Product product = new Product();
        
        public override void BuildPartA()
        {
            product.Add("PartA");
        }

        public override void BuildPartB()
        {
            product.Add("PartB");
        }

        public override Product GetResult()
        {
            return this.product;
        }
    }
}
