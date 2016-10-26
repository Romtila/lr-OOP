using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba2
{
    class Wizard : Player
    {
        protected int mana;

        public int Mana 
        {
            get { return mana; }
            set { mana = value; }
        }

        public Wizard()
        {
            Life = 100;
            Strange = 10;
            Dexterity = 10;
            Intelligence = 15;
        }

        public Wizard(int life, int strange, int dexterity, int intelligence, int mana)
        {
            this.life = life;
            this.strange = strange;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
            this.mana = mana;
        }

        public void LevelUp()
        {
            level += 1;
            strange += 5;
            dexterity += 5;
            intelligence += 5;
        }

        protected int AttackUp
        {
            get { return Intelligence * 5; }
        }

        public int ChanceToDodgeAttack(int attack)
        {
            return Dexterity / attack / 100;
        }

        public bool CanAttack(Effect effect)
        {
            bool status = true;
            foreach (string name in Enum.GetValues(typeof(Effect.EffectDictionary)))
            {
                if (effect.EffectType == (string)name)
                {
                    status = false;
                }
            }
            return status;
        }

        public override void Attack(TargetObject targetObject, Effect effect, Weapon weapon)
        {
            if (CanAttack(effect))
            {
                targetObject.Life = targetObject.Life - weapon.Damage;
            }
        }

        public override void EquipWeapon(Weapon weapon)
        {
            if (weapon.Requirements != new Requirements(Strange, Dexterity, Intelligence))
            {
                new PlayerOutfitException("low performance");
            }
            if (weapon.WeaponType != "staff")
            {
                new PlayerOutfitException("Type of weapon is wrong");
            }
        }

        public override void EquipOutfit(Armor armor)
        {
            if (armor.Requirements != new Requirements(Strange, Dexterity, Intelligence))
            {
                new PlayerOutfitException("low performance");
            }
            if (armor.ArmorType != "cape")
            {
                new PlayerOutfitException("Type of armor is wrong");
            }
        }

        public override void AddEffect(Effect effect)
        {
            if (effect.Duration == -1)
            {
                effect = new Effect(effect.EffectType, effect.Duration);
            }
        }
    }
}
