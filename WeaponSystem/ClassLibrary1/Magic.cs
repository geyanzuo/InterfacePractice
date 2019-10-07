using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Magic : Weapon, Idmg
    {
        public Magic(string pname, double pbasedamage, int pbaserange, int pdistance) : base(pname, pbasedamage, pbaserange, pdistance)
        {
        }

        public double GetDMG()
        {
            Random criticalchance = new Random();
            if (Distance <= BaseRange)
            {
                if(criticalchance.Next(100) <= 2)
                {
                    BaseDamage = BaseDamage * 2;
                }
                else
                {
                    BaseDamage = BaseDamage * 1;
                }
            }

            else if (Distance > BaseRange)
            {
                BaseDamage = 0;
                Console.WriteLine("MISS!");
            }
            return BaseDamage;
        }
    }
}
