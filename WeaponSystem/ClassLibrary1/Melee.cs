using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Melee: Weapon, Idmg
    {
        public Melee(string pname, double pbasedamage, int pbaserange, int pdistance) : base(pname, pbasedamage, pbaserange, pdistance)
        {
        }

        public double GetDMG()
        {
            Random hitchance = new Random();
            Random criticalchance = new Random();
            if (hitchance.Next(100) <= 85)
            {
                if (Distance <= BaseRange * 0.5)
                {
                    BaseDamage = BaseDamage * 1.2;
                }
                else if (Distance > BaseRange * 0.5 && Distance <= BaseRange)
                {
                    BaseDamage = BaseRange;
                }
                else if (criticalchance.Next(100) <= 2)
                {
                    BaseDamage = BaseDamage * 2;
                }
                else if (Distance > BaseRange)
                {
                    BaseDamage = 0;
                    Console.WriteLine("MISS!");
                }
            }

            else 
            {
                BaseDamage = 0;
                Console.WriteLine("MISS!");
            }

            return BaseDamage;
        }

       
    }
}
