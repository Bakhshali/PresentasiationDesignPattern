using System;
using System.Collections.Generic;
using System.Text;

namespace Visitors
{
    internal class Promotion : IVisitor
    {
        public void Visit(Vehicle vehicle)
        {
            vehicle.Cost *= 0.9;
        }
    }
}
