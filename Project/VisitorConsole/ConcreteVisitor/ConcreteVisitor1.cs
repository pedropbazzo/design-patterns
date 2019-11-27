﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorConsole
{
    class ConcreteVisitor1 : IVisitor
    {
        public void VisitConcreteElementA(ConcreteElementA element)
        {
            Console.WriteLine($"{element.ExclusiveMethodOfConcreteElementA()} ConcreteVisitor1");
        }

    public void VisitConcreteElementB(ConcreteElementB element)
    {
        Console.WriteLine($"{element.SpecialMethodOfConcreteElementB()} ConcreteVisitor1");
        }
    }
}
