using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba2
{
    class Effect : IEquatable<Effect>
    {
        protected string effecttype;
        public enum EffectDictionary { оглушение, яд, укус, слюна, слизь, паутина, заморозка }
        protected double duration;

        public Effect(string effecttype, double duration)
        {
            this.effecttype = effecttype;
            this.duration = duration;
        }
        public Effect()
        {

            duration = 1;
        }

        public string EffectType 
        {
            get { return effecttype; }
            set { effecttype = value; }
        }
        public double Duration 
        {
            get { return duration; }
            set { duration = value; }
        }        

        public bool EffectDo
        {
            get
            {
                if (duration > 0)
                { return true; }
                else
                { return false; }
            }
        }

        public bool Equals(Effect obj)
        {
            if (obj == null || effecttype != obj.effecttype)
            { return true; }
            else
            { return false; }
        }

        public int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Effect eff1, Effect eff2)
        {
            if ((eff1.effecttype == eff2.effecttype) && (eff1.duration == eff2.duration))
                return true;
            return false;
        }

        public static bool operator !=(Effect eff1, Effect eff2)
        {
            if ((eff1.effecttype != eff2.effecttype) || (eff1.duration != eff2.duration))
                return true;
            return false;
        }
    }
}
