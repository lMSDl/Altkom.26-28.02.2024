﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._26_28._02._2024.DesignPatterns.Behavioral.Visitor.I
{
    internal interface IVisitor
    {
        void Visit(PlainText element);
        void Visit(BoldText element);
        void Visit(Hyperlink element);
    }
}