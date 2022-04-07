using System;
using System.Collections.Generic;
using System.Text;

namespace Visitors
{
    public interface IVisitor
    {
        public void Visit(Vehicle vehicle);
    }
}
