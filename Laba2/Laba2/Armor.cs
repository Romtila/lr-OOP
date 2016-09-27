using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba2
{
    class Armor : StrDexInt
    {
        protected double defense;
        protected string armortype;

        public double Defense
        {
            get { return defense; }
            set { defense = value; }
        }
        public string ArmorType
        {
            get { return armortype; }
            set { armortype = value; }
        }
        protected override double Requirements
        {
            get { return base.Requirements; }
        }
    }
}
