using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba2
{
    abstract class StrDexInt
    {
        protected double strange;
        protected double dexterity;
        protected double intelligence;

        protected virtual double Requirements
        {
            get { return strange; }
        }
    }
}
