using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba2
{
    class Effect : IEquatable<Effect>
    {
        protected string effecttype;
        protected double duration;
        protected bool alltime;

        public bool AllTime
        {
            get { return alltime; }
            set { alltime = value; }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
