using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using MIS321_PA2.Interfaces;
using System.Threading.Tasks;

namespace MIS321_PA2
{
    public class JackSparrow : Character //this is where you do the bonuses
    {
        public void Attack()
        {
            System.Console.WriteLine("Look at the bird over there! *I am distracting you*");
        }
        public double JackBonus()
        {
            double jackBonus = ((MaxPower - DefensivePower) * (0.2));
            return jackBonus;
        }
    }
}