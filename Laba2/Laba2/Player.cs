using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba2
{
    abstract class Player : TargetObject
    {
        protected double strange;
        protected double dexterity;
        protected double intelligence;
        protected int level;
        protected string[] effects;

        public override double Life
        {
            get { return life; }
            set { life = value; }
        }
        abstract public double Strange
        {
            get { return strange; }
            set { strange = value; }
        }
        abstract public double Dexterity
        {
            get { return dexterity; }
            set { dexterity = value; }
        }
        abstract public double Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }
        abstract public int Level
        {
            get { return level; }
            set { level = value; }
        }
        abstract public string Effects
        {
            public get 
            {
                for (int i; i<effects.Length; i++)
                {
                    return effects[i];
                }
            }
            private set { effects = value; }
        }

        public string this[int index]
        {
            get { return effects[index]; }
            private set { effects[index] = value; }
        }

        public Player()
        {
            life = 100;
            strange = 10;
            dexterity = 10;
            intelligence = 10;
            level = 1;
            effects = null;
        }

        public abstract TargetObject Attack();
        public abstract Weapon EquipWeapon();
        public abstract Armor EquipOutfit();
        public abstract Effect AddEffect();
    }
}
