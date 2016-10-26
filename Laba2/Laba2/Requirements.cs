using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba2
{
    class Requirements
    {
        protected int strange;
        protected int dexterity;
        protected int intelligence;

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

        public Requirements()
        {
            strange = 10;
            dexterity = 10;
            intelligence = 10;
        }

        public Requirements(int strange, int dexterity, int intelligence)
        {
            this.strange = strange;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
        }
    }
}
