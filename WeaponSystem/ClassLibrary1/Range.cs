using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Range : Weapon, Idmg
    {
        public Range(string pname, double pbasedamage, int pbaserange, int pdistance) : base(pname, pbasedamage, pbaserange, pdistance)
        {
        }

        public double GetDMG()
        {
            Random hitchance = new Random();
            Random criticalchance = new Random();
            Random randdmg = new Random();

            if(Distance <= BaseRange)
            {
                if(hitchance.Next(100) <= 75)
                {
                    BaseDamage = BaseDamage * 1;
                }
                
                else
                {
                    BaseDamage = 0;
                    Console.WriteLine("MISS!");
                }

            }
            else if (Distance > BaseRange)
            {

            }
            return BaseDamage;
        }
    }
}
