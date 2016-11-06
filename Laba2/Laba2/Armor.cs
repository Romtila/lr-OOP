using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba2
{
    class Armor 
    {
        protected int defense;

        
        public string ArmorType { get; set; }
        public Requirements Requirements { get; set; }

        public enum ArmorDictionary { lats, jacket, helmet, pants, boots, shorts, cape }


        public Armor(int Defense, string ArmorType, Requirements Requirements)
        {
            this.defense = defense;
            foreach (string name in Enum.GetValues(typeof(ArmorDictionary)))
            {
                if (ArmorType == (string)name)
                {
                    this.ArmorType = ArmorType;
                }
                else
                {
                    this.ArmorType = "cape";
                }
            }
            this.Requirements = Requirements;
        }
    }
}
