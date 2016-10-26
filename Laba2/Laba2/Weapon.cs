using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba2
{
    class Weapon 
    {
        protected int damage;
        protected string weapontype;
        protected Requirements requirements;
        public enum WeaponDictionary { sword, staff, wand, dagger, crush }

        public int Damage 
        {
            get { return damage; }
            set { damage = value; }
        }
        public string WeaponType
        {
            get { return weapontype; }
            set { weapontype = value; }
        }
        public Requirements Requirements 
        {
            get { return requirements; }
            set { requirements = value; }
        }

        public Weapon(int damage, string weapontype, Requirements requirements)
        {
            this.damage = damage;
            foreach (string name in Enum.GetValues(typeof(WeaponDictionary)))
            {
                if (weapontype == (string)name)
                {
                    this.weapontype = weapontype;
                }
                else
                {
                    this.weapontype = "staff";
                }
            }
            this.requirements = requirements;
        }
    }
}
