﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Shop : IVisitable
    {

        public double Price { get; set; }
        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
