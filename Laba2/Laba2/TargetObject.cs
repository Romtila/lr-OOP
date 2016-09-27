using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba2
{
    abstract class TargetObject
    {
        protected double life;
        abstract public double Life
        {
            get { return life; }
            set { life = value; }
        }
    }
}
