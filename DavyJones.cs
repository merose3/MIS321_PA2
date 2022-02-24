using System;
using System.Collections.Generic;
using System.Linq;
using MIS321_PA2.Interfaces;
using System.Threading.Tasks;

namespace MIS321_PA2
{
    public class DavyJones : Character //this is where you do the bonuses
    {
        public void Attack()
        {
            System.Console.WriteLine("BOOM! *I am blowing you up*");
        }
        public double DavyBonus()
        {
            double davyBonus = ((MaxPower - DefensivePower) * (0.2));
            return davyBonus;
        }
    }
}