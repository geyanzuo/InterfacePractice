using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Weapon
    {
        public string Name;
        public double  BaseDamage;
        public int BaseRange;
        public int Distance;

        public Weapon(string pname, double  pbasedamage, int pbaserange, int pdistance)
        {
            Name = pname;
            BaseDamage = pbasedamage;
            BaseRange = pbaserange;
            Distance = pdistance;
        }

        public double GetPokeDMG()
        {
            return BaseDamage = 1;
        }
    }
}
