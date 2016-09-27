using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba2
{
    class Wizard : Player
    {
        protected double mana;

        public double Mana
        {
            get { return mana; }
            set { mana = value; }
        }

        public Wizard() : base()
        {
            base.intelligence = 20;
            mana = 100;
        }


        public override double Intelligence
        {
            get { return this.intelligence; }
            set { this.intelligence = value; }
        }
        public override double Strange
        {
            get { return this.strange; }
            set { this.strange = value; }
        }
        public override double Dexterity
        {
            get { return this.dexterity; }
            set { this.dexterity = value; }
        }
        public override int Level
        {
            get { return this.level; }
            set { this.level = value; }
        }
        public override double Life
        {
            get { return this.Life; }
            set { this.Life = value; }
        }
        public override string Effects
        {
            get { throw new NotImplementedException(); }
        }
        
        public override Effect AddEffect()
        {
            throw new NotImplementedException();
        }
        public override TargetObject Attack()
        {
            throw new NotImplementedException();
        }
        public override Armor EquipOutfit()
        {
            throw new NotImplementedException();
        }
        public override Weapon EquipWeapon()
        {
            throw new NotImplementedException();
        }

        public void LevelUp()
        {
            level++;
            strange++;
            dexterity++;
            intelligence = intelligence + 2;
        }

        public double ChanceToDodgeAttack()
        {
            return dexterity * 0.1;
        }
    }
}
