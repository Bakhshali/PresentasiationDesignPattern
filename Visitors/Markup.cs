using System;
using System.Collections.Generic;
using System.Text;

namespace Visitors
{
    internal class Markup : IVisitor
    {
        public void Visit(Vehicle vehicle)
        {
            vehicle.Cost += 2.500;
        }
    }
}
