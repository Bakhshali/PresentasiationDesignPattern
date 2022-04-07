using System;
using System.Collections.Generic;
using System.Text;

namespace Visitors
{
    public class Vehicle:IAcceptVisitors
    {
       virtual public double Cost { get; set; } = 0;

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);    
        }
    }

    public class Car : Vehicle
    { 
        override public double Cost { get; set; } =5000;
    }

    public class BMW : Vehicle
    {
        public override double Cost { get; set; } = 6000;
    }

    public class Truck : Vehicle
    {
        override public double Cost { get; set; } = 20000;
    }

}
