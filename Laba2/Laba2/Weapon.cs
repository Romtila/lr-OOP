using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba2
{
    class Weapon : StrDexInt
    {
        protected double damage;
        protected string weapontype;        

        public double Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        public string WeaponType
        {
            get { return weapontype; }
            set { weapontype = value; }
        }
        public override double Requirements
        {
            get { return base.Requirements; }
        } 
    }
}
