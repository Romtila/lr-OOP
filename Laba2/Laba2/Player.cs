using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba2
{
    abstract class Player : TargetObject
    {
        protected int strange;
        protected int dexterity;
        protected int intelligence;
        protected int effects;
        protected int level;
        protected Weapon weapon;
        protected Armor armor;

        public override int Life 
        {
            get { return life; }
            set { life = value; }
        }        

        public int Strange 
        {
            get { return strange; }
            set { strange = value; }
        }
        public int Dexterity 
        {
            get { return dexterity; }
            set { dexterity = value; }
        }
        public int Intelligence 
        {
            get { return intelligence; }
            set { intelligence = value; }
        }
        public int Effects 
        { 
            get; 
            protected set; 
        }
        public int Level 
        { 
            get; 
            protected set; 
        }
        public Weapon Weapon 
        {
            get { return weapon; }
            set { weapon = value; }
        }
        public Armor Armor 
        {
            get { return armor; }
            set { armor = value; }
        }

        public Player()
        {
            Life = 100;
            Strange = 10;
            Dexterity = 10;
            Intelligence = 10;
            Effects = 0;
            Level = 1;
            Armor = new Armor(20, "cape", new Requirements(1, 1, 1));
            Weapon = new Weapon(10, "staff", new Requirements(1, 1, 1));
        }

        public Player(int Life, int Strange, int Dexterity, int Intelligence, int Effects, int Level, Armor Armor, Weapon Weapon)
        {
            this.Life = Life;
            this.Strange = Strange;
            this.Dexterity = Dexterity;
            this.Intelligence = Intelligence;
            this.Effects = Effects;
            this.Level = Level;
            this.Armor = Armor;
            this.Weapon = Weapon;
        }

        public abstract void Attack(TargetObject targetObject);
        public abstract void EquipWeapon(Weapon weapon);
        public abstract void EquipOutfit(Armor armor);
        public abstract void AddEffect(Effect effect);
    }
}
