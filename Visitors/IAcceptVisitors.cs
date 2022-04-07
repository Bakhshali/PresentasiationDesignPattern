using System;
using System.Collections.Generic;
using System.Text;

namespace Visitors
{
    public interface IAcceptVisitors
    {
        public void Accept(IVisitor visitor);
    }
}
