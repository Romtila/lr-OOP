using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba2
{
    class Effect : IEquatable<Object>
    {
        protected string effecttype;
        public enum EffectDictionary { оглушение, яд, укус, слюна, слизь, паутина, заморозка }
        protected double duration;

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

        public Effect(string effecttype, double duration)
        {
            this.effecttype = effecttype;
            this.duration = duration;
        }

        public bool EffectDo
        {
            get
            {
                if (duration == -1)
                { return true; }
                else
                { return false; }
            }
        }

        public bool Equals(Effect obj)
        {
            if (obj == null)
            {
                return false;
            }
            Effect p = obj as Effect;
            if ((Object)p == null)
            {
                return false;
            }
            return (effecttype == p.effecttype) && (duration == p.duration);
        }

        public int GetHashCode()
        {
            return effecttype.GetHashCode();
        }

        public static bool operator ==(Effect eff1, Effect eff2)
        {
            if ((eff1.effecttype == eff2.effecttype) && (eff1.duration == eff2.duration) && (eff1.EffectDo == eff2.EffectDo))
                return true;
            return false;
        }

        public static bool operator !=(Effect eff1, Effect eff2)
        {
            if ((eff1.effecttype != eff2.effecttype) || (eff1.duration != eff2.duration) || (eff1.EffectDo != eff2.EffectDo))
                return true;
            return false;
        }
    }
}
